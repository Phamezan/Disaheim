using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {

        public string ItemId { get; set; }
        public Level Quality { get; set; }
        public string Design { get; set; }

        public Amulet(string itemId) : this (itemId, Level.medium,"")
        {
        }


        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}

