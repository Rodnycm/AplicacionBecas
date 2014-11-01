using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public partial class Alerts : Form
    {
        public Alerts()
        {
            InitializeComponent();
        }

       static Alerts alerta; static DialogResult result = DialogResult.No;

        public static DialogResult Show(String Text)
        {
            alerta = new Alerts();
            alerta.lblAlerta.Text = Text;
            alerta.btnAceptar.Text = "Aceptar";
            alerta.ShowDialog();
            alerta.BringToFront();
            return result;

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; alerta.Close();
        }
    }
    }

