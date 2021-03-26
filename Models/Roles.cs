namespace Practica6.Models
{
    public class Roles
    {
        public int Id{get;set;}
        
        public string NombreRol{get;set;}

        public Roles()
        {
            
        }

        public Roles(int Id, string NombreRol)
        {
            this.Id = Id;
            this.NombreRol = NombreRol;
        }
    }
}