using System;

namespace programa_02
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            string cadena ="";
            int edad = 0;
            double altura = 0.0;
            
            
            Console.WriteLine("Buenas, por favor ingrese su edad aquí:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            
            
            if(edad <= 10)
            {
                Console.WriteLine("Disculpe, pero usted no tiene la edad suficiente para entrar a este parque.");
            }
            else
            {
                
                
                Console.WriteLine("¡Bienvenido sea!");
                
                Console.WriteLine("¿cual es su altura? (En metros)");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);
                
                if(altura < 1.3)
                {
                Console.WriteLine("¡¡Puede disfrutar del gusanito, las sillas voladoras, del carrusel y del trencito!!");    
                }
                else
                {
                    Console.WriteLine("¡¡Puede disfrutar de la casa del terror, de la montaña rusa y del martillo!!");
                
                }
                //
            }
            
            
            
            
            Console.ReadKey();
               }
    }
}   

