using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain
{
    public class Blockchain
    {
        // create genesis block
        private readonly List<Block> _chain = new() { new() };

        public Block GetLastBlock()
        {
            return _chain[^1];
        }

        public void AddBlock(Block newBlock)
        {
            var lastBlock = GetLastBlock();

            newBlock.Hash = Ext.GetHash(lastBlock.PrevHash + newBlock.Timestamp + newBlock.Data);
            newBlock.PrevHash = lastBlock.Hash;

            _chain.Add(newBlock);
        }

        public bool IsValid()
        {
            for (int i = 1; i <= _chain.Count; i++)
            {
                var currentBlock = _chain[i];
                var prevBlock = _chain[i - 1];

                if (prevBlock.Hash == currentBlock.PrevHash)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
