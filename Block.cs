using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain
{
    internal class Block
    {
        public string Timestamp { get; set; }
        public string Data { get; set; }
        public string Hash { get; set; }
        public string PrevHash { get; set; } = string.Empty;

        public Block(string data)
        {
            Data = data;
            Timestamp = Calc.GetTimestamp();
            Hash = Calc.GetHash(PrevHash, Timestamp, Data);
        }
    }
}
