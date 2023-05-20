using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain
{
    public class Block
    {
        public static int Id { get; set; }
        public string Timestamp { get; set; }
        public string Data { get; set; }
        public string Hash { get; set; }
        public string PrevHash { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Block Id: {Id}\nTimestamp: {Timestamp}\nData: {Data}\nHash: {Hash}\nPrevHash: {PrevHash}\n";
        }

        public Block(string data)
        {
            Id++;
            Data = data;
            Timestamp = Ext.GetTimestamp();
            Hash = Ext.GetHash(PrevHash, Timestamp, Data);
        }
    }
}
