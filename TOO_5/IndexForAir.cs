using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOO_5
{
    class IndexForAir : Civil
    {
        public IndexForAir (string Name, int Tempest) : base(Name, Tempest) { }

        public Air this[int i]
        {
            get { return new Civil(Name, Tempest); }
        }

        public override void ShowInfo()
        {
            MessageBox.Show($"Назва{name}" + $"\nКількість пасажирів{tempest}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
