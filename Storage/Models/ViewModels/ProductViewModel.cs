using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models.ViewModels
{
    public class ProductViewModel
    {
        // Id
        public int Id { get; set; }

        // Name
        public string Name { get; set; }

        // Price
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { get; set; }

        // Count
        public int Count { get; set; }

        // InventoryValue
        [Display(Name = "Inventory Value")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int InventoryValue { get; set; }
    }
}
