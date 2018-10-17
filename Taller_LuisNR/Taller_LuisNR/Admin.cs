using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_LuisNR
{
    class Admin
    {
        public static string user;
        Usuario Editor = new Usuario
        {
            User = "LANR",
            Name = "Luis",
            LastName = "Reyes",
            TipoUsario = "Editor",
            Id = 123


        };
        Usuario Visita = new Usuario
        {
            User = "RBK",
            Name = "Rebeca",
            LastName = "Barrientos",
            TipoUsario = "Visita",
            Id = 321


        };

        public void n1()
        {
            Console.WriteLine("Nombre de Usuario");
            string userinput = Console.ReadLine();
            if (userinput == Visita.User)
            {
                user = Visita.TipoUsario;
                n2();
            }
            else if (userinput == Editor.User)
            {
                user = Editor.TipoUsario;

                n3();
            }
            else
            {
                Console.WriteLine("no se encuentra el usuario");
                n1();
            }
            //Console.ReadKey();
        }
        public void n2()
        {
            Console.WriteLine("Usuario visita\n" + "Opciones\n" + "A. Nuevo Comentario\n" + "B. Lista de publicaciones");
            string Opcion = Console.ReadLine();
            if (Opcion == "A")
            {
                n4();
            }
            else if (Opcion == "B")
            {
                n3();
            }
            else
            {
                n2();
            }

        }
        public void n3()
        {
            Console.WriteLine("Usuario Editor\n" + "Opciones\n" + "A. Nueva publicacion\n" + "B. Lista de publicaciones");
            string Opcion = Console.ReadLine();
            if (Opcion == "A")
            {
                n4();
            }
            else if (Opcion == "B")
            {
                n5();
            }
            else
            {
                n3();
            }

        }
        public void n4()
        {

        }
        public void n5()
        {

        }
    }
}
