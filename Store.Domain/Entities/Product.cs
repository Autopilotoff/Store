using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Store.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue=false)]
        public int ProductID { get; set; }
        
        [Required(ErrorMessage = "Введите наименование товара")]
        public string Name { get; set; }
 
        [Required(ErrorMessage = "Введите описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Введите положительную цену товара")]
        public decimal Price { get; set; }
        
        [Required (ErrorMessage = "Укажите категорию")]        
        public string Category { get; set; }
        
        //public byte ImageData { get; set; }
        
        //[HiddenInput(DisplayValue = false)]
        //public string ImageMimeType { get; set; }
    }

    
}
