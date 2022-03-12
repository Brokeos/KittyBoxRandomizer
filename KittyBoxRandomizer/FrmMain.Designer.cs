namespace KittyBoxRandomizer
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupParticipants = new System.Windows.Forms.GroupBox();
            this.listParticipants = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupGifts = new System.Windows.Forms.GroupBox();
            this.listGifts = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnParticipantsLoad = new System.Windows.Forms.Button();
            this.btnGiftsLoad = new System.Windows.Forms.Button();
            this.groupEntries = new System.Windows.Forms.GroupBox();
            this.listEntries = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnComputeEntries = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtKittyBoxName = new System.Windows.Forms.TextBox();
            this.groupParticipants.SuspendLayout();
            this.groupGifts.SuspendLayout();
            this.groupEntries.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupParticipants
            // 
            this.groupParticipants.Controls.Add(this.listParticipants);
            this.groupParticipants.Location = new System.Drawing.Point(12, 12);
            this.groupParticipants.Name = "groupParticipants";
            this.groupParticipants.Size = new System.Drawing.Size(455, 228);
            this.groupParticipants.TabIndex = 0;
            this.groupParticipants.TabStop = false;
            this.groupParticipants.Text = "Participants";
            // 
            // listParticipants
            // 
            this.listParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listParticipants.FullRowSelect = true;
            this.listParticipants.GridLines = true;
            this.listParticipants.HideSelection = false;
            this.listParticipants.Location = new System.Drawing.Point(6, 19);
            this.listParticipants.MultiSelect = false;
            this.listParticipants.Name = "listParticipants";
            this.listParticipants.Size = new System.Drawing.Size(443, 203);
            this.listParticipants.TabIndex = 0;
            this.listParticipants.UseCompatibleStateImageBehavior = false;
            this.listParticipants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kitty";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wallet";
            this.columnHeader1.Width = 315;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Timeframe";
            this.columnHeader2.Width = 62;
            // 
            // groupGifts
            // 
            this.groupGifts.Controls.Add(this.listGifts);
            this.groupGifts.Location = new System.Drawing.Point(473, 12);
            this.groupGifts.Name = "groupGifts";
            this.groupGifts.Size = new System.Drawing.Size(301, 228);
            this.groupGifts.TabIndex = 1;
            this.groupGifts.TabStop = false;
            this.groupGifts.Text = "Gifts";
            // 
            // listGifts
            // 
            this.listGifts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGifts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listGifts.FullRowSelect = true;
            this.listGifts.GridLines = true;
            this.listGifts.HideSelection = false;
            this.listGifts.Location = new System.Drawing.Point(6, 19);
            this.listGifts.MultiSelect = false;
            this.listGifts.Name = "listGifts";
            this.listGifts.Size = new System.Drawing.Size(289, 203);
            this.listGifts.TabIndex = 1;
            this.listGifts.UseCompatibleStateImageBehavior = false;
            this.listGifts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 56;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            this.columnHeader8.Width = 166;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Priority";
            this.columnHeader9.Width = 43;
            // 
            // btnParticipantsLoad
            // 
            this.btnParticipantsLoad.Location = new System.Drawing.Point(386, 2);
            this.btnParticipantsLoad.Name = "btnParticipantsLoad";
            this.btnParticipantsLoad.Size = new System.Drawing.Size(75, 23);
            this.btnParticipantsLoad.TabIndex = 1;
            this.btnParticipantsLoad.Text = "Load";
            this.btnParticipantsLoad.UseVisualStyleBackColor = true;
            this.btnParticipantsLoad.Click += new System.EventHandler(this.btnParticipantsLoad_Click);
            // 
            // btnGiftsLoad
            // 
            this.btnGiftsLoad.Location = new System.Drawing.Point(693, 2);
            this.btnGiftsLoad.Name = "btnGiftsLoad";
            this.btnGiftsLoad.Size = new System.Drawing.Size(75, 23);
            this.btnGiftsLoad.TabIndex = 2;
            this.btnGiftsLoad.Text = "Load";
            this.btnGiftsLoad.UseVisualStyleBackColor = true;
            this.btnGiftsLoad.Click += new System.EventHandler(this.btnGiftsLoad_Click);
            // 
            // groupEntries
            // 
            this.groupEntries.Controls.Add(this.listEntries);
            this.groupEntries.Location = new System.Drawing.Point(12, 246);
            this.groupEntries.Name = "groupEntries";
            this.groupEntries.Size = new System.Drawing.Size(401, 228);
            this.groupEntries.TabIndex = 1;
            this.groupEntries.TabStop = false;
            this.groupEntries.Text = "Entries";
            // 
            // listEntries
            // 
            this.listEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.listEntries.FullRowSelect = true;
            this.listEntries.GridLines = true;
            this.listEntries.HideSelection = false;
            this.listEntries.Location = new System.Drawing.Point(6, 19);
            this.listEntries.MultiSelect = false;
            this.listEntries.Name = "listEntries";
            this.listEntries.Size = new System.Drawing.Size(389, 203);
            this.listEntries.TabIndex = 0;
            this.listEntries.UseCompatibleStateImageBehavior = false;
            this.listEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Wallet";
            this.columnHeader10.Width = 290;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Entries";
            this.columnHeader11.Width = 72;
            // 
            // btnComputeEntries
            // 
            this.btnComputeEntries.Location = new System.Drawing.Point(332, 236);
            this.btnComputeEntries.Name = "btnComputeEntries";
            this.btnComputeEntries.Size = new System.Drawing.Size(75, 23);
            this.btnComputeEntries.TabIndex = 3;
            this.btnComputeEntries.Text = "Compute";
            this.btnComputeEntries.UseVisualStyleBackColor = true;
            this.btnComputeEntries.Click += new System.EventHandler(this.btnComputeEntries_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(693, 438);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(81, 36);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(419, 320);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(355, 65);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "KittyBox Randomizer";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKittyBoxName
            // 
            this.txtKittyBoxName.Location = new System.Drawing.Point(565, 447);
            this.txtKittyBoxName.Name = "txtKittyBoxName";
            this.txtKittyBoxName.Size = new System.Drawing.Size(122, 20);
            this.txtKittyBoxName.TabIndex = 6;
            this.txtKittyBoxName.Text = "kittybox-1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.txtKittyBoxName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnComputeEntries);
            this.Controls.Add(this.groupEntries);
            this.Controls.Add(this.btnGiftsLoad);
            this.Controls.Add(this.btnParticipantsLoad);
            this.Controls.Add(this.groupGifts);
            this.Controls.Add(this.groupParticipants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 524);
            this.MinimumSize = new System.Drawing.Size(800, 524);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KittyBoxRandomizer";
            this.groupParticipants.ResumeLayout(false);
            this.groupGifts.ResumeLayout(false);
            this.groupEntries.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupParticipants;
        private System.Windows.Forms.ListView listParticipants;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupGifts;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listGifts;
        private System.Windows.Forms.Button btnParticipantsLoad;
        private System.Windows.Forms.Button btnGiftsLoad;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupEntries;
        private System.Windows.Forms.ListView listEntries;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnComputeEntries;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtKittyBoxName;
    }
}

