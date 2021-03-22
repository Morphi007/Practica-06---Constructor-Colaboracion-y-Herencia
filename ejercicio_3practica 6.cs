using System;

namespace practica_6_ejercicio_3
{
   
    
    
    class A
    {

        private string clasea;
        public string Clasea
        {
            set
            {
                clasea = value;
            }

            get
            { return clasea; }


        }

    }

    class B:A
    {
        protected string claseb;
        public string Claseb
        {
            set
            {
               claseb = value;
            }

            get
            { return claseb; }


        }

        public void imprimir()
        {

            Console.WriteLine("soy de clase A: " + Clasea);
            Console.WriteLine("soy de clase B: " + Claseb);
           
        }



    }

    class C:B
    {

        protected string clasec;
        public string Clasec
        {
            set { clasec= value; }
            get { return clasec; }

        }



        new public void imprimir()

        {

            base.imprimir();

            Console.WriteLine("soy de clase C :"+clasec);


        }


    }








    class Program
    {
        static void Main(string[] args)
        {

            C clasec = new C();
            clasec.Clasea = "Estudio ingenieria en sofware\n";
            clasec.Claseb= "Estudio robotica\n";
            clasec.Clasec="estudio base de datos\n";
            clasec.imprimir();
            Console.ReadKey();
        
        }
    }
}
