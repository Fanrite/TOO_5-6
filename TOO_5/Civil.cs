using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TOO_5
{
    class Civil : Air
    {
        public Civil(string name, int tempest) : base(name, tempest) { }

        public Civil() : base()
        {
            tempest = Convert.ToInt32(Interaction.InputBox("Введіть кількість пасажирів", "Введення"));
        }

        public override void ShowInfo()
        {
            MessageBox.Show($"Назва{name}" + $"\nКількість пасажирів{tempest}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool operator ==(Civil p1, Civil p2)
        {
            return p1.Tempest == p2.Tempest;
        }
        public static bool operator !=(Civil p1, Civil p2)
        {
            return !(p1 == p2);
        }
        public static Civil operator ++(Civil p)
        {
            p.Tempest += 2;
            return (p);
        }
    }
}
