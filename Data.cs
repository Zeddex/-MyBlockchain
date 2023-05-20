using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyBlockchain
{
    public struct Data
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"From: {From}, To: {To}, Amount: {Amount}";
        }
    }
}
