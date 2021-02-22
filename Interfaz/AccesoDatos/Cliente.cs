using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace AccesoDatos
{
    public class Cliente
    {
        public static void Main(string[] args)
        {

        }
        [Key]
        public int ID { get; set; }
        public string  Nombre { get; set; }
        public string Telefono { get; set; }
    }

    
}
