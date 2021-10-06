using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TOO_5
{
    abstract class Air
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }
        protected int tempest; 
        public int Tempest { get { return tempest; } set { if (value > 0) tempest = value; } }

        public Air (string name, int tempest)
        {
            this.name = name;
            this.tempest = tempest;
        }
        
        public Air()
        {
            name = Interaction.InputBox("Введіть назву", "Введення");
        }

        ~Air()
        {
            MessageBox.Show($"Знищується літак ", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        public abstract void ShowInfo();

       
    }
}
