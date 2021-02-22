using System;
using System.Data.Entity;
using System.Linq;

namespace AccesoDatos
{
    public class Clientes : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Cliente' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'AccesoDatos.Cliente' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Cliente'  en el archivo de configuración de la aplicación.
        public Clientes()
            : base("name=Cliente")
        {
            Database.SetInitializer<Clientes>(new CreateDatabaseIfNotExists<Clientes>());
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Cliente> Client { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}