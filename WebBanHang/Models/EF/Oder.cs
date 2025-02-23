using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Oder")]
    public class Oder:CommonAbstract
    {
        public Oder()
        { 
            this.OderDetails = new HashSet<OderDetail>();   
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]

        public string Code { get; set; }
        [Required]
        public string CustomerName  { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }

        public decimal TotalAmont { get; set; }

        public int Quanity  { get; set; }   
        public ICollection<OderDetail> OderDetails { get; set; }    
    }
}