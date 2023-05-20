using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain
{
    internal class Blockchain
    {
        private List<Block> chain;
        Data data;

        public Blockchain()
        {
            // create genesis block
            chain = new List<Block> { new() };
        }

        public Block GetLastBlock()
        {
            return chain[^1];
        }

        public void AddBlock(Block newBlock)
        {
            var lastBlock = GetLastBlock();

            newBlock.Hash = Ext.GetHash(lastBlock.PrevHash + newBlock.Timestamp + newBlock.Data);
            newBlock.PrevHash = lastBlock.Hash;

            chain.Add(newBlock);
        }

        public bool IsValid()
        {
            for (int i = 1; i <= chain.Count; i++)
            {
                var currentBlock = chain[i];
                var prevBlock = chain[i - 1];

                if (prevBlock.Hash != currentBlock.Hash || prevBlock.Hash != currentBlock.PrevHash)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
