
 class Musico
  {
        public string Nombre  
          {
            get;
            set;
          }

          public Musico(string n )
          {
               Nombre= n;
          }
          public void saluda()
          {
            Console.WriteLine("Hola");

          }
          public virtual void Tocar()
          {
            Console.WriteLine($"{Nombre} esta tocando su instrumento"); //tocando su instrumento
          }

          class baterista: Musico
          {
                public string bateria
            {
                get;
                set;
            }
            public baterista(string n , string b): base(n)
            {
                bateria= b;
            }
            public override void Tocar ()
            {
                Console.WriteLine($"{Nombre} esta tocando su {bateria}");
            }
                  //posee una bateria
                  //Tocar(); nombre toca su bateria
          }
          class bajista: Musico
          {
            public string bajo
            {
                get;
                set;
            }
            public bajista(string n , string b): base(n)
            {
                bajo= b;
            }
            public override void Tocar ()
            {
                Console.WriteLine($"{Nombre} esta tocando su {bajo}");
            }
            //posee una bajo
                  //Tocar(); nombre toca su bajo
          }
  }
        internal class Program
    {
   
         private static void Main(string[] args)
    {
        List<Musico> grupo= new List<Musico>();
        grupo.Add (new Musico("UwU"));
        grupo.Add (new bajista("Haitham", "Alhacen"));
        grupo.Add (new baterista("Ayaka", "Aya"));
         foreach( var m in grupo)
         {
               m.saluda();
         }
           foreach( var m in grupo)
         {
               m.Tocar();
         }
   
    }
}