using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Subcribe")]
    public class Subcribe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]         
        
        public int ID { get; set; }

        public string Email { get; set; }

        public DateTime CreateDate { get; set; }    
    }
}