using System;

namespace vApp
{
    class Program
    {  
        static void Main(string[] args)
        {
            clsNoti[] mensaje = new clsNoti[3];
            mensaje[0] = new clsCorreo("fernando.fa671@gmail.com");
            mensaje[1] = new clsSms("70252765");
            mensaje[2] = new clsWsp("70252765");
            for (int i = 0; i < mensaje.Length; i++)
            {
                mensaje[i].Mensaje = " hola soy yo...";
                Console.WriteLine(mensaje[i].Enviar());
            }

            Console.ReadKey();
        }
    }
}
