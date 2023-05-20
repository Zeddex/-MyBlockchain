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
            chain = new List<Block> { new Block(data) };
        }

        public Block GetLastBlock()
        {
            return chain[^1];
        }

        public void AddBlock(Block block)
        {
            var lastBlock = GetLastBlock();
            block.PrevHash = Ext.GetHash(lastBlock.PrevHash, lastBlock.Timestamp, data.ToString());

            chain.Add(block);
        }

        public bool IsValid()
        {
            for (int i = 0; i < chain.Count; i++)
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
