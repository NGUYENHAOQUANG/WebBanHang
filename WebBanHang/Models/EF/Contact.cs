using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "Tên không được để trống")]
        public int ID { get; set; } 

        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "không được vượt quá 150 ký tự")]
        public string Email { get; set; }

        public string Website { get; set; }

        [StringLength(4000)]
        public string Message { get; set; }     

        public int IsRead { get; set; }
    }
}