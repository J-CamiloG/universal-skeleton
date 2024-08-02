using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skeleton.MiApp.model
{
    public abstract class Persona
    {
        protected Guid Id { get; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }


        public Persona( string nombre, string apellido, string numeroDocumento, string email, string telefono)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
        }

        // get para la lectura de las propiedades protectec
        public Guid GetId()
        {
            return Id;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetApellido()
        {
            return Apellido;
        }
        public string GetEmail()
        {
            return Email;
        } 
        public string GetTelefono()
        {
            return Telefono;
        }

        // set para los edit de las propiedades
        public void GetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void GetApellido( string apellido)
        {
            Apellido = apellido;
        }
        public void GetEmail( string email)
        {
            Email = email;
        } 
        public void GetTelefono(string telefono)
        {
            Telefono = telefono;
        }

        //metodo mostrar informacion
        public virtual void MostrarInformacion()
        {   
            Console.WriteLine($"| Nombre: {Nombre} | Apellido: {Apellido} | Documento: {NumeroDocumento} | Email: {Email} | Teléfono: {Telefono}");
        }
    }
}