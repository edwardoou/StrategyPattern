using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Computadora",
                    Price = 299.99m
                },
                new Product
                {
                    Name = "Shampoo",
                    Price = 1.49m
                },
                new Product
                {
                    Name = "Carro",
                    Price = 24999.99m
                }
            };

            var costoChina = new CostoChina();
            var costoUsa = new CostoUSA();
            var costoAustralia = new CostoAustralia();
            var produccionCosto = new ProduccionCosto();

            Console.WriteLine($"El costo de produccion para {products[0].Name} en China es " +
                $"{produccionCosto.Calcular(products[0], costoChina)}");
            Console.WriteLine($"El costo de produccion para {products[1].Name} en Australia es " +
                $"{produccionCosto.Calcular(products[1], costoAustralia)}");
            Console.WriteLine($"El costo de produccion para {products[2].Name} en USA es " +
                $"{produccionCosto.Calcular(products[2], costoUsa)}");

            Console.ReadKey();
        }
    }
}