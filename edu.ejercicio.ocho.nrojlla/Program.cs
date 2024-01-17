namespace edu.ejercicio.ocho.nrojlla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] texto = { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos" };

            int lugar = Array.IndexOf(texto, "Adiós"); 
            if(lugar == -1)
            {
                Console.WriteLine("No se encuentra");

            }   else
            {
                Console.WriteLine("Posicion: " +  lugar);
            }

            //pedir palabra
            Console.WriteLine("Ingrese una palabra para buscar");
            string buscar = Console.ReadLine();
     

            if (texto.Contains(buscar))
            {
                Console.WriteLine("La palabra existe.");

            }
            else
            {
                Console.WriteLine("La palabra no existe, intentelo de nuevo");
            }

            //Array de enteros

            Console.WriteLine("Numeros mayores que 3:");

            int[] numeros = { 1, 5, 7, 8, 4, 3, 9 };

            var mayores = numeros.Where(num => num > 3);

            foreach (int numero in mayores)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
