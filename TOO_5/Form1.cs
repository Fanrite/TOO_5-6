using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TOO_5
{
    public partial class Form1 : Form
    {
        Air a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n = "dd";
            int t = 12;
            n = Interaction.InputBox("Введіть назву", "Введення");
            t = Convert.ToInt32(Interaction.InputBox("Введіть кількість пасажирів", "Введення"));
            a = new Civil(n, t);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == null) MessageBox.Show($"objekt not found 404", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else a.Name = Interaction.InputBox("Введіть назву", "Введення");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == null) MessageBox.Show($"objekt not found 404", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else a.Tempest = Convert.ToInt32(Interaction.InputBox("Введіть кількість пасажирів", "Введення"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = new Civil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string n;
            int t;
            n = Interaction.InputBox("Введіть назву", "Введення");
            t = Convert.ToInt32(Interaction.InputBox("Введіть кількість ракет", "Введення"));
            b = new Mili(n, t);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (b == null) MessageBox.Show($"objekt not found 404", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else b.Name = Interaction.InputBox("Введіть назву", "Введення");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (b == null) MessageBox.Show($"objekt not found 404", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else b.Tempest = Convert.ToInt32(Interaction.InputBox("Введіть кількість ракет", "Введення"));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b = new Mili();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var vp = new IndexForAir("da", 20 );
            int i = 1;
            MessageBox.Show("Літак № " + i.ToString() + " має пасажирів " +
            vp[i].Tempest + " од.", "Інформація", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var g = new Civil("Fly", 10);
            g++;
            g.ShowInfo();
            ++g;
            g.ShowInfo();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var g1 = new Civil("one", 20);
            g1.ShowInfo();
            var g2 = new Civil("two", 22);
            g2.ShowInfo();
            if (g1 == g2) MessageBox.Show("Пасажири рівні");
            else MessageBox.Show("Пасажири не рівні");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = null;
        }
    }
}
