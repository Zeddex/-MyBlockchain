using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain
{
    public class Block
    {
        public int Id { get; set; }
        public string Timestamp { get; set; }
        public Data Data { get; set; }
        public string Hash { get; set; }
        public string PrevHash { get; set; }
        public static int Count { get; set; }

        public override string ToString()
        {
            return $"Block Id: {Id}\nTimestamp: {Timestamp}\nData: {Data}\nHash: {Hash}\nPrevHash: {PrevHash}\n";
        }

        /// <summary>
        /// Create genesis block
        /// </summary>
        public Block()
        {
            Id = Count = 1;
            Timestamp = Ext.GetTimestamp();
            Hash = Ext.GetHash(Timestamp);
        }

        public Block(Data data)
        {
            Id = ++Count;
            Data = data;
            Timestamp = Ext.GetTimestamp();
        }
    }
}
