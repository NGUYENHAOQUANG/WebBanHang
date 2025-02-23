using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_OderDetail")]
    public class OderDetail
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int OrderId { get; set; }

        public int ProductId { get; set; }  

        public decimal Price { get; set; }

        public int Quanity { get; set; }        

        public virtual Oder Oder { get; set; }

        public virtual Product Product { get; set; }    

    }
}