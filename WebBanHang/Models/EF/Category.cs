using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.EF
{

    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        public Category() 
        { 
        this.News = new HashSet<News>();   
        }   
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(150)]  
        public string Title { get; set; }

        public string Alias { get; set; }   

        public string Description { get; set; }

        [StringLength(150)]
        public string SeoTtile { get; set; }
        [StringLength(250)]
        public string SeoDecription { get; set; }
        [StringLength(150)]
        public string SeoKeyWords {  get; set; }

        public bool isActive { get; set; }
        public int Position { get; set; }

        public ICollection<News> News { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}