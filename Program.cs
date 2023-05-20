﻿using MyBlockchain;

Data data;

var myBlockchain = new Blockchain();

Console.WriteLine($"Genesis Block:\n{myBlockchain.GetLastBlock()}");

myBlockchain.AddBlock(new Block(new Data()
{
    From = "Joe",
    To = "Max",
    Amount = 1000
}));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block(new Data()
{
    From = "Sam",
    To = "Bo",
    Amount = 500
}));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block(new Data()
{
    From = "Matt",
    To = "Phil",
    Amount = 3000
}));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block(new Data()
{
    From = "Adam",
    To = "Martha",
    Amount = 200
}));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block(new Data()
{
    From = "Jenny",
    To = "Sarah",
    Amount = 900
}));
Console.WriteLine(myBlockchain.GetLastBlock());

Console.ReadLine();