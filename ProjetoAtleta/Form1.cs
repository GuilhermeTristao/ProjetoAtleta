using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
       Atleta obj = new Atleta();

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Altura =Double.Parse( txt_altura.Text);
                obj.Peso = Double.Parse(txt_peso.Text);
                obj.Nome = txt_altura.Text;
            }catch(FormatException ex){
                MessageBox.Show("Erro. \n" + ex.Message);


            }
            catch(Exception ex)
            {

                MessageBox.Show("Erro. \n" + ex.Message);
            }


            try
            {
                MessageBox.Show("Seu Imc é :" + obj.CalcularIMC());

            }
            catch
            {

                MessageBox.Show("Algo deu errado :(");
            }
          









        }
    }
}
