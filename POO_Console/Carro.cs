using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Console
{
    class Carro : IVeiculo
    {
        private int velocidade;
        public int Velocidade
        {
            get
            {
                return velocidade;
            }
            set
            {
                velocidade = value;
            }
        }


        //Construtor
        public Carro(int veloc)
        {
            velocidade = veloc;
        }
        public Carro()
        {
            velocidade = 0;        }
   
        
        public void Acelerar()
        {
            velocidade = velocidade + 10;
        }

        public void Frenar()
        {
            velocidade = velocidade - 7;
        }
    }
}
