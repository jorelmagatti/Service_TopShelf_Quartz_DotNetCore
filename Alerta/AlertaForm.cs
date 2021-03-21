using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alerta
{
    public partial class AlertaForm : Form
    {
        private string[] data { get; set; }
        public AlertaForm()
        {
            InitializeComponent();
            data = Environment.GetCommandLineArgs();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTituloAlerta.Text = $"ALERTA DAS {DateTime.Now}";
            if (data.Count() > 1)
            {
                string menssagem = string.Empty;
                int contador = 0;
                foreach (var item in data)
                {
                    if(contador != 0)
                    {
                        menssagem = menssagem + " " + item;
                        contador++;
                    }
                    else
                    {
                        contador++;
                    }
                }

                lblMensagemAlerta.Text = $"Alerta das {DateTime.Now} \r\n -> Informação sobre este alerta:\r\n{menssagem}";
            }
            else
            {
                lblMensagemAlerta.Text = $"Alerta das {DateTime.Now} \r\n -> Informação sobre este alerta:\r\nResultado padrão da alerta...";
            }
            lblTituloAlerta.Refresh();
            lblMensagemAlerta.Refresh();
        }
    }
}
