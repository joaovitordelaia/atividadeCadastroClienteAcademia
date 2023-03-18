using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academiaRegistro
{
    class Pessoa
    {
        string nome;
        int idade;
        double peso;
        double altura;
        double imc;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Imc { get => imc; set => imc = value; }

        public Pessoa(string nome, int age, double weight, double height)
        {
            this.Nome = nome;
            this.Idade = age;
            this.Peso = weight;
            this.Altura = height;
            
        }

        // Para Alterar os Atributos

        public void AlterarNome(string nome)
        {
            this.Nome = nome;
        }

        public void Alteraridade(int idade)
        {
            this.Idade = idade;
        }

        public void AlterarPeso(double peso)
        {
            this.Peso = peso;
        }

        public void AlterarAltura(double altura)
        {
            this.Altura = altura;
        }

           // Para consultar os Atributos

        public string LerNome()
        {
            return this.Nome;
        }

        public int LerIdade()
        {
            return this.Idade;
        }

        public double LerPeso()
        {
            return this.Peso;
        }

        public  double LerAltura()
        {
            return this.Altura;
        }

        public double LerImc()
        {
            return this.Imc;
        }

        // para calcular imc

        public void CalcularImc()
        {

            this.Imc = this.peso / (this.altura * this.altura);

        }



    }
}
