namespace helloword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Persona persona1 = new Persona();
            persona1.Nombre = "sefora";
            persona1.Edad = 17;

            Persona persona2 = new Persona();
            persona2.Nombre = "owen";
            persona2.Edad = 18;

            //Llamar al metodo saludar 
            persona1.Saludar();
            persona2.Saludar();





        }
    }
}
