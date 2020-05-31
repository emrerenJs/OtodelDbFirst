using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtodelDBFirst.MyObjects
{
    class ComboBoxItem
    {
        public string key { get; set; }
        public string value { get; set; }
        public ComboBoxItem(string key,string value)
        {
            this.key = key;
            this.value = value;
        }
        public override string ToString()
        {
            return this.value;
        }
    }
}
