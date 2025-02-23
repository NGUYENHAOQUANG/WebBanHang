﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Product")]
    public class Product:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        public string Alias { get; set; }
        public string ProductCode { get; set; } 

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }  
        public decimal PriceSale { get; set; }  

        public int Quanity { get; set; }    

        public bool IsHome { get; set; }    

        public bool IsSale { get; set; }

        public bool IsFeature { get; set; }

        public bool IsHot { get; set; } 


        public int ProductCategoryId { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDescription { get; set; }

        public string SeoKeyWords { get; set; }

        public bool isActive { get; set; }
        public virtual ProductCategori ProductCategori { get; set; }    

    }
}