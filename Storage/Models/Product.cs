using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        // ID
        public int Id { get; set; }

        // Name
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        //Price
        [Range(0, int.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { get; set; }

        //DateTime
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Orderdate { get; set; }

        //Category
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Category { get; set; }

        //Shelf
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Shelf { get; set; }

        //Count
        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        //Description
        [StringLength(50)]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Description { get; set; }


    }
}
