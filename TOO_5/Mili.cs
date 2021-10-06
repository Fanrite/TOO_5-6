using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TOO_5
{
    class Mili : Air
    {
        public Mili(string name, int tempest) : base(name, tempest) { }

        public Mili() : base()
        {
            tempest = Convert.ToInt32(Interaction.InputBox("Введіть кількість ракет", "Введення"));
        }

        public override void ShowInfo()
        {
            MessageBox.Show($"Назва{name}" + $"\nКількість ракет{tempest}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
