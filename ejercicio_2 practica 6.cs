using System;

namespace ejercicio_2
{
    
    
    class Contacto
    {

        private string nombre;
        public string Nombre
        {

            set
            {
                nombre = value;
            }
            get { return nombre; }
        }
//------------------------------------------///
        private string apellido;
        public string Apeliddo
        {

            set { nombre = value; }
            get { return  nombre;}
        }
        //---------------------------------------------///

        private string telefono;
        public string Telefono
        {

            set { telefono = value; }
            get { return telefono; }
        }
        //--------------------------------------------------///


        private string dirrecion;
        public string Dirrecion
        {

            set { dirrecion = value; }
            get { return dirrecion; }
        }

        //--------------------------------------------------------///


        public void SetContacto()
        {
            Console.WriteLine("ingresa tu Nombre\n");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido\n");
            apellido = Console.ReadLine();
            Console.WriteLine("ingresa tu telefono\n");
            telefono = Console.ReadLine();
            Console.WriteLine("ingresa tu dirrecion\n");
            dirrecion = Console.ReadLine();
        }



        public void saludar()
        {

            Console.WriteLine("Hola soy:" +nombre, "Apellido"+apellido," telefono"+telefono," dirrecion"+dirrecion);
        }



    
    


    class ProbarContacto:Contacto
    {
        static void Main(string[] args)
        {
        

                Contacto contacto1 = new Contacto();
                Contacto contacto2 = new Contacto();
                Console.WriteLine("contacto #1 \n");
                contacto1.SetContacto();
                contacto1.saludar();
                Console.WriteLine("------------------");
                Console.WriteLine("contacto #2 \n");
                contacto1.SetContacto();
                contacto1.saludar();




            }
        }
    }
}
