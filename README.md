# KittyBoxRandomizer

## What is it ?

KittyBoxRandomizer is a software that randomly draw a winner for each gift of the KittyBox.

## How to use ?

### Requirements

- [Download .NET Framework 4.7.2 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)

### Software

- [Download the latest KittyBoxRandomizer release](https://github.com/Brokeos/KittyBoxRandomizer/releases)

### Data

Download the latest staking contract snapshot and the gifts csv in Discord.

### Run

Click on "Compute Button" and "Draw".

![result](https://i.ibb.co/QvyG4v9/KBRandomizer.png)

### Logs

Logs highlights every single step the software went through to pick the winners. 
Make sure you have enough storage before running the program, the logs require a bit of disk storage.

#### results.txt

Contains the result of the draw

```csv
0x432c516ec89ed5e05bf82f2a1da88e52455af0a0,1
0xe16d4126a779dbb5bac95f61a90dc17397d89e1b,2
0x0048fafa0350c1c06c2f37f25cd74cd25e290580,3
```

#### losers.txt

Contains every wallet without gift

```csv
0x02fc864e4f43990623e1cd6ea2f2e1cba93ee38f
0x57d82566a8e35158ad5b33146483fc008febebeb
0x8b41bb055955fe9c0e0860a3b23a841785c2638f
```

#### logs.txt

Contains events

#### cX-rX-gifts.txt

Contains the remaining gifts in the round X of the cycle X

#### cX-rX-tickets.txt

Contains the remaining tickets in the round X of the cycle X

#### cX-rX-winner.txt

Contains the winner of the round X of the cycle X