using MyBlockchain;

var myBlockchain = new Blockchain();

var genesisBlock = myBlockchain.GetLastBlock();
Console.WriteLine($"Genesis Block:\n{genesisBlock}");

myBlockchain.AddBlock(new Block("from: Joe, to: Max, amount: 1000"));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block("from: Sam, to: Bo, amount: 500"));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block("from: Matt, to: Phil, amount: 3000"));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block("from: Adam, to: Martha, amount: 200"));
Console.WriteLine(myBlockchain.GetLastBlock());

myBlockchain.AddBlock(new Block("from: Jenny, to: Sarah, amount: 900"));
Console.WriteLine(myBlockchain.GetLastBlock());

Console.ReadLine();