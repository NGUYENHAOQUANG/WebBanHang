using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_ProductCategori")]
    public class ProductCategori:CommonAbstract
    {
        public ProductCategori() 
        { 
            this.products = new HashSet <Product>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public string SeoTtile { get; set; }

        public string SeoDecription { get; set; }

        public string SeoKeyWords { get; set; }

        public ICollection<Product> products { get; set; }

    }
}