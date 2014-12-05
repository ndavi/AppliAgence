using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class ComboBoxItem
    {
        public string Name;
        public int Value;
        public ComboBoxItem(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
}
