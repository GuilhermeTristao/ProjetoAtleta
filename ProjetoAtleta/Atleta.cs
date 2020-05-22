using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura, peso;
        private int idade;

        public string Nome
        {
            set {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome é obrigatório");
                }

                   
            
            }
            get { return this.nome; }


        }
        public double Altura
        {
            set
            {
                if (value > 1.00)
                {

                    this.altura = value;

                }
                else
                {
                    throw new Exception("Altura digitada de forma incorreta(deve ser maior de 1.00m)");
                }


            }

            get { return this.altura; }






        }
        public double Peso
        {
            set
            {
                if (value > 1.00)
                {

                    this.peso = value;

                }
                else
                {
                    throw new Exception("Peso digitado de forma incorreta(deve ser maior de 1.00kg)");
                }


            }

            get { return this.peso; }






        }
        public int Idade
        {
            set
            {
                if (value > 1.00)
                {

                    this.idade = value;
                }
                else
                {
                    throw new Exception("Digite a idade corretamente(maior que 1.00");
                }




            }

            get { return this.idade; }

        }



        public  string imprimirdados()
        {
            return "Dados da pessoa\n\nNome: " + this.nome + "\nIdade: " + this.idade + "\nAltura: " + this.altura.ToString("0.00") + "m";
        }



        public double CalcularIMC()
        {
            double imc= this.peso / Math.Pow(this.altura, 2);
            return imc;


        }


    }

   
}
