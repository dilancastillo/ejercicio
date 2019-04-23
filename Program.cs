using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var montoPrestamo = 17000000;
            var pagosMes = montoPrestamo / 12;
            var interesMensual = 2;
            int valorTotalInteres;
            double interesDiasRetraso = 0.02;
            var retrasoDias = pagosMes + (pagosMes * interesDiasRetraso / 100);


            //En esta operacion se muestra el valor del interes
            valorTotalInteres = montoPrestamo * interesMensual / 100;

            Console.WriteLine($"El valor del interes es: {valorTotalInteres}");
            Console.WriteLine($"El valor de la mensualidad a pagar es: {pagosMes}");
            Console.WriteLine($"El valor del pago por retraso es: {retrasoDias}");
            Console.WriteLine("Digite la fecha de consignacion");
            Console.ReadLine();

            
            //montoFinal = Math.Pow((1 + interesMensual), tiempo) * montoPrestamo;


           





    



            
        }
    }
}
