using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeta_Atleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ratleta obj = new Ratleta();
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Double total;
            total = (obj.Peso / (obj.Altura * obj.Altura));
            string resultado = Convert.ToString(total);
            txt_imc.Text = resultado.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.Altura = double.Parse(txt_altura.Text);
                obj.Peso = int.Parse(txt_peso.Text);
                obj.Idade = int.Parse(txt_idade.Text);
                MessageBox.Show("Dados Armazenados!");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
