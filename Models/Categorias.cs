using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Practica03_Teoria.Models
{    

    [Table("t_categorias")]
    public class Categorias
    {
       
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id {get; set;}

       public string nombre {get; set;}

       public ICollection<Solicitudes> solicitudes {get; set;}
       

    }
}