using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class Login
    {   //clase para realizar el login 
        //instancia de las clases
        Registro R = new Registro();
        Usuario Us = new Usuario();
        List<Usuario> Usuarios = new List<Usuario>();
        //creacion de la lista
        public void ingresarDatos()
        {//ingreso de los datos para logear contraseña y nombre de usuario
            Console.WriteLine("ingrese UserName: ");
             Us.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese password:");
            Us.Password = Console.ReadLine();
            string ruta = "E:/program/autenticacion/Autenticacion/Autenticacion/bin/Debug/archivo.txt";
            List<string> datos = R.ObetnerLineas(ruta);
            //lista hacia donde se ira a buscar y ruta donde se encuentra el archivo 
            Usuarios.Add(Us);
            //agregar ala lista
            validarDatos(ruta,datos);
            //llamada al metodo
        }

       

        public void validarDatos(string ruta, List<string>datos)
        {
            //metodo para validar datos
            //condicion para validar
            foreach (var item in datos)
            {//comprobacion
                string[] inf = item.Split(',');
                //agregar ala lista
                Usuarios.Add (new Usuario {Nombre = inf[0] });
            }


            foreach (var Uss in Usuarios)
            {
                if (Us.UserName == Uss.UserName && Us.Password == Uss.Password)
                {
                    //comprobacion del login si el usuario y la contrase son igual a los datos que se encuentran en el archivo txt y la lista se manda a llamar el metodo bienvenida
                    Bienvenida();

                }
                

               

            }
        }

        public void Bienvenida()
        {//mensaje metodo bienvenida
            Console.WriteLine("Logeo exitoso");
            Console.ReadKey();
           
        }

        public void Bienvenida2()
        {
            Console.WriteLine("Logeo exitoso");
            Console.ReadKey();

        }

    }
}
