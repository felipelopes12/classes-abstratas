using Model.Classes;
using System;

namespace AbstracaoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c = new Cachorro();
            c.setTamanho(20);
            c.setIdade(12);
            c.setPeso(8);
            

            Console.WriteLine($"Tamanho: {c.getTamanho()}, " +
                              $"Idade: {c.getIdade()}, " +
                               $"Peso: {c.getPeso()}");
           
            c.fazBarulho();
            c.Comer();

            Console.WriteLine("----------------------------------------");

            Lobo l = new Lobo();
            l.setTamanho(35);
            l.setIdade(10);
            l.setPeso(10);

            Console.WriteLine($"Tamanho: {l.getTamanho()}, " +
                               $"Idade: {l.getIdade()}, " +
                                $"Peso: {l.getPeso()}");

            l.fazBarulho();
            l.Comer();
            l.Dormir();

            Console.WriteLine("----------------------------------------");

            Gato g = new Gato();
            g.setTamanho(20);
            g.setIdade(12);
            g.setPeso(8);

            Console.WriteLine($"Tamanho: {g.getTamanho()}, " +
                              $"Idade: {g.getIdade()}, " +
                               $"Peso: {g.getPeso()}");
            g.fazBarulho();
            g.Vaguear();
            g.Comer();
            g.Dormir();

            Console.ReadLine();
        }
    }
}
