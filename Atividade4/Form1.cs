using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        Font fonteGrande = new Font("Microsoft Sans Serif", 24F);
        Font fontePequena = new Font("Microsoft Sans Serif", 9F);
        public Form1()
        {
            InitializeComponent();
            this.textBox1.BackColor = Color.White;

        }


        private void modoAltoContrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.altoContrasteMenuItem.CheckState == CheckState.Unchecked)
            {

                this.textBox1.BackColor = Color.FromArgb(30, 30, 30);
                this.textBox1.ForeColor = Color.White;

                this.BackColor = Color.Black;
                this.ForeColor = Color.White;


                this.configMenu.BackColor = Color.Black;
                this.configMenu.ForeColor = Color.White;

                this.altoContrasteMenuItem.BackColor = Color.Black;
                this.altoContrasteMenuItem.ForeColor = Color.White;

                this.ampliadoMenuItem.BackColor = Color.Black;
                this.ampliadoMenuItem.ForeColor = Color.White;

                

                this.altoContrasteMenuItem.CheckState = CheckState.Checked;
            } else
            {
                this.textBox1.BackColor = Color.White;
                this.textBox1.ForeColor = Color.Black;

                this.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                this.ForeColor = Color.Black;

                this.configMenu.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                this.configMenu.ForeColor = Color.Black;

                this.altoContrasteMenuItem.BackColor = Color.White;
                this.altoContrasteMenuItem.ForeColor = Color.Black;

                this.ampliadoMenuItem.BackColor = Color.White;
                this.ampliadoMenuItem.ForeColor = Color.Black;

                this.altoContrasteMenuItem.CheckState = CheckState.Unchecked;
            }
        }

        private void modoAmpliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ampliadoMenuItem.CheckState == CheckState.Unchecked)
            {
                this.textBox1.Font = this.fonteGrande;
                this.configMenu.Font = this.fonteGrande;
                this.ampliadoMenuItem.CheckState = CheckState.Checked;
            }
            else
            {
                this.textBox1.Font = this.fontePequena;
                this.configMenu.Font = this.fontePequena;
                this.ampliadoMenuItem.CheckState = CheckState.Unchecked;
            }

        }
    }
}
