using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Practica03_Teoria.Models
{    

    [Table("t_solicitudes")]
    public class Solicitudes
    {
       
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id {get; set;}
       
       [Required(ErrorMessage = "El nombre del Producto es Requerido")]
       public string nombre {get; set;}
       
        [Required(ErrorMessage = "La foto es Requerido")]
       public string foto {get; set;}
       
        [Required(ErrorMessage = "La descripcion es Requerido")]
       public string descripcion {get; set;}
       
        [Required(ErrorMessage = "El precio es Requerido")]
       public decimal precio {get; set;}
       
        [Required(ErrorMessage = "El numero de celular es Requerido")]
       public string celular {get; set;}
       
        [Required(ErrorMessage = "El nombre del lugar es requerido")]
       public string lugar{get; set;}
       
        [Required(ErrorMessage = "El nombre del comprador es requerido")]
       public string comprador {get; set;}

       public DateTime fecha {get; set;}
      
       
       public Categorias Categorias {get; set;}

       
       public Solicitudes()
       {

           this.fecha = DateTime.Now;
           
       }
       

    }
}