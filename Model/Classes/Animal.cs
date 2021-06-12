using System;

namespace Model.Classes
{
    public abstract class Animal
    {
        private int Tamanho;
        private int Idade;
        private int Peso;

        public int getTamanho() { return Tamanho; }
        public void setTamanho(int Tamanho) { this.Tamanho = Tamanho; }

        public int getIdade() { return Idade; }
        public void setIdade(int Idade) { this.Idade = Idade; }

        public int getPeso() { return Peso; }

        public void setPeso(int Peso) { this.Peso = Peso; }

        public abstract void fazBarulho();
       
        public abstract void Comer();

        public virtual void Vaguear() { }  

        public void Dormir()
        {
            Console.WriteLine("O Animal está Dormindo...");
        }
    
    }
}


/* public string Tamanho { get;set; }

        public decimal Peso { get;set; }

        public int Idade { get;set; }


--------------------------------------------------
 ABSTRACT substituido por VIRTUAL.
*/


