
using System;
using System.Collections;

namespace Practica4
{
	/// <summary>
	/// Description of Directorio.
	/// </summary>
	public class Directorio
	{
        public Hashtable tabla = new Hashtable();
		public Directorio()
		{
			this.tabla = new Hashtable();
		}
		public void capturar () {
			for (int i=0; i<4; i++){
				Persona p= new Persona ();
				Console.WriteLine("Codigo");
				p.codigo =int.Parse(Console.ReadLine());
				
				Console.WriteLine("nombre");
				p.nombre= Console.ReadLine();
				
				Console.WriteLine("telefono");
				p.telefono=Console.ReadLine();
				
				Console.WriteLine("facebook");
				p.facebook=Console.ReadLine();
				this.tabla.Add(p.codigo,p);
			}
			 
		}


    
		public void editar () {
            int codigoEditar;
			for (int i=0; i<2; i++){
			Console.WriteLine("Codigo que decea editar");
           codigoEditar = int.Parse(Console.ReadLine());

           Persona p = (Persona)this.tabla[codigoEditar];

           Console.WriteLine("Editando la llave: " + p.codigo);
			Console.WriteLine("nombre");
				p.nombre= Console.ReadLine();
				Console.WriteLine("telefono");
				p.telefono=Console.ReadLine();
				Console.WriteLine("facebook");
				p.facebook=Console.ReadLine();
                this.tabla[codigoEditar] = p;// leo mi tabla
                 if (!this.tabla.ContainsKey(codigoEditar)){
                	Console.WriteLine("codigoEditar" + p.codigo + "la llava ya fue editada");
                }
			}
			
		}

		public void eliminar() {
            int codigoEliminar;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Codigo que desea eliminar");
                codigoEliminar = int.Parse(Console.ReadLine());

                if (this.tabla.ContainsKey(codigoEliminar)){
                	this.tabla.Remove(codigoEliminar);
                	Console.WriteLine("eliminado");
                }else{
                	Console.WriteLine("codigoEliminar" + codigoEliminar + "No se encuentra la llave");
                }


            }
		}

		public void imprimir () {
            ICollection keys = this.tabla.Keys;//Icolletion obtiene un valor que indica solo lectura

            Console.WriteLine("\t\tCodigo:\t\tNombre\t\tTelefono\t\t\tFacebook");

            foreach (int key in keys)//foreach repite un grupo de instrucciones incrustadas para cada elemento
            //o colección de objetos que implementa la interfaz 
            {

                Persona p = (Persona)this.tabla[key];//mando a llamar mi llave
                Console.WriteLine("\t\t" + p.codigo + "\t\t" + p.nombre + "\t\t" + p.telefono + "\t\t\t" + p.facebook);
                //imprime datos del cliente
            }
		}
			
	}
}
