using System;

namespace practica_06_ejercicio_1
{

    class persona{

//--------------cedula-----------------------
        private int cedula;
        public int Cedula
        {
            set
            {
                cedula = value;
            }
            get
            {return cedula;}

              }
    //------------Nombre------------------------//*
        private string nombre;
        public string Nombre
          {
        set
        {
                nombre = value;
        }

            get
            {return nombre;}


        }

//----------------apellido------------------------//*

        private string apellido;
        public string Apellido
        {
            set
            {
                apellido = value;

            }
            get { return apellido; }


        }

        //-------------------edad------------------------


        private int edad;
        public int Edad
        {

            set 
            {
                edad = value;
            }
            get { return edad; }
        }
    
    
      public void imprimir()
        {

            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Cedula: " + Cedula);

        }
    
    
           
    
    
    }



    class Profesor:persona
    {

        private float sueldo;
        public float Sueldo
        {
            set
            {
                sueldo =value;
            }
            get { return sueldo; }
            

        }

        new public void imprimir()
        
        {

           base.imprimir();

            Console.WriteLine("sueldo "+Sueldo);


        }





    }






    class Program
    {
        static void Main(string[] args)
        {
            
            persona  persona1 = new persona();
           
            persona1.Cedula =4025482;
            persona1.Nombre = "Morphi";
            persona1.Apellido = "MARTINEZ";
            persona1.Edad = 20;
            persona1.imprimir();
            Console.WriteLine("\n");

            Profesor profe = new Profesor();
            profe.Cedula =0154796;
            profe.Nombre = "profesor";
            profe.Apellido = "moreta";
            profe.Edad = 25;
            profe.Sueldo =45000;
            profe.imprimir();
            Console.ReadKey();
        }
    }
}