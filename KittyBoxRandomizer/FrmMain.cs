using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace KittyBoxRandomizer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnParticipantsLoad_Click(object sender, EventArgs e)
        {
            try {
                listParticipants.Items.Clear();

                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "CSV File (*.csv) | *.csv";
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileData = ofd.FileName;
                    string[] lines = File.ReadAllLines(fileData);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        ListViewItem item = new ListViewItem(parts[0]);

                        item.SubItems.Add(parts[1]);
                        item.SubItems.Add(parts[3]);

                        listParticipants.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGiftsLoad_Click(object sender, EventArgs e)
        {
            try
            {
                listGifts.Items.Clear();

                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "CSV File (*.csv) | *.csv";
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileData = ofd.FileName;
                    string[] lines = File.ReadAllLines(fileData);
                    string kittyBoxID = "";

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        ListViewItem item = new ListViewItem(parts[0]);

                        item.SubItems.Add(parts[1]);
                        item.SubItems.Add(parts[13]);

                        if (kittyBoxID.Equals(""))
                        {
                            kittyBoxID = parts[10];
                        }

                        listGifts.Items.Add(item);
                    }

                    txtKittyBoxName.Text = String.Format("kittybox-{0}", kittyBoxID);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComputeEntries_Click(object sender, EventArgs e)
        {
            listEntries.Items.Clear();

            Dictionary<string, Dictionary<int, int>> entries = new Dictionary<string, Dictionary<int, int>>();

            foreach (ListViewItem participant in listParticipants.Items)
            {
                string wallet = participant.SubItems[1].Text;
                int timestamp = int.Parse(participant.SubItems[2].Text);
                Dictionary<int, int> data = null;

                if (entries.ContainsKey(wallet))
                {
                    data = entries[wallet];
                }
                else
                {
                    data = new Dictionary<int, int>();
                }

                if (data.ContainsKey(timestamp))
                {
                    data[timestamp] = data[timestamp] + 1;
                }
                else
                {
                    data.Add(timestamp, 1);
                }

                entries[wallet] = data;
            }

            foreach (KeyValuePair<string, Dictionary<int, int>> data in entries)
            {

                ListViewItem item = new ListViewItem(data.Key);
                int totalEntries = 0;

                foreach (KeyValuePair<int, int> timestamp in data.Value)
                {
                    totalEntries += ((timestamp.Value * 2) - 1) * (timestamp.Key / 45);
                }

                item.SubItems.Add(totalEntries.ToString());

                listEntries.Items.Add(item);
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            List<string> tickets = computeTickets();
            List<string> giftIds = new List<string>();
            List<string> giftNames = new List<string>();
            int round = 1;
            int cycle = 1;
            string rootFolder = String.Format("./{0}", txtKittyBoxName.Text);

            foreach (ListViewItem gift in listGifts.Items)
            {
                giftIds.Add(gift.SubItems[0].Text);
                giftNames.Add(gift.SubItems[1].Text);
            }

            if (Directory.Exists(rootFolder))
            {
                Directory.Delete(rootFolder, true);
            }

            Directory.CreateDirectory(rootFolder);

            StreamWriter swLogs = new StreamWriter(String.Format("{0}/logs.txt", rootFolder));
            StreamWriter swResults = new StreamWriter(String.Format("{0}/results.txt", rootFolder));

            swLogs.WriteLine("Start Time: {0}", DateTime.Now);
            swLogs.WriteLine("Starting Cycle {0}", cycle);

            while(giftIds.Count > 0)
            {
                swLogs.WriteLine("Starting Round {0}", round);
                tickets.Shuffle();

                StreamWriter swTickets = new StreamWriter(String.Format("{0}/c{1}-r{2}-tickets.txt", rootFolder, cycle, round));
                StreamWriter swGifts = new StreamWriter(String.Format("{0}/c{1}-r{2}-gifts.txt", rootFolder, cycle, round));
                StreamWriter swWinner = new StreamWriter(String.Format("{0}/c{1}-r{2}-winner.txt", rootFolder, cycle, round));
                string giftId = giftIds[0];
                string giftName = giftNames[0];
                string winner = tickets[0];

                swTickets.WriteLine(String.Join("\n", tickets));
                swGifts.WriteLine(String.Join("\n", giftNames));
                swWinner.WriteLine("{0} - {1}({2})", winner, giftName, giftId);

                giftIds.RemoveAt(0);
                giftNames.RemoveAt(0);

                swLogs.WriteLine("{0} - {1}({2})", winner, giftName, giftId);
                swResults.WriteLine("{0},{1}", winner, giftId);

                while (tickets.Contains(winner))
                {
                    tickets.Remove(winner);
                }

                if (tickets.Count == 0)
                {
                    swLogs.WriteLine("Cycle is done, new cycle is starting");
                    tickets = computeTickets();
                    cycle++;
                }

                swTickets.Close();
                swGifts.Close();
                swWinner.Close();
                round++;
            }

            if (round == 1)
            {
                StreamWriter swLosers = new StreamWriter(String.Format("{0}/losers.txt", rootFolder));

                foreach (string ticket in tickets.Distinct())
                {
                    swLosers.WriteLine(ticket);
                }

                swLosers.Close();
            }

            swLogs.WriteLine("End Time: {0}", DateTime.Now);
            swLogs.Close();
            swResults.Close();

            MessageBox.Show("Draw is complete");
        }

        private List<string> computeTickets()
        {
            List<string> tickets = new List<string>();

            foreach (ListViewItem entry in listEntries.Items)
            {
                string wallet = entry.SubItems[0].Text;
                int totalEntries = int.Parse(entry.SubItems[1].Text);

                for (int i = 0; i < totalEntries; i++)
                {
                    tickets.Add(wallet);
                }
            }

            return tickets;
        }

    }
}
