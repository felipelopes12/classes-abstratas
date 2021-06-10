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

        public void Dorme()
        {
            Console.WriteLine("O Animal está a dormir.");
        }

        public abstract void fazBarulho();
        public abstract void Comer();

        public abstract void Vaguear();
    }
}