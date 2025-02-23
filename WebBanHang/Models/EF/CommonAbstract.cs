using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    public abstract class CommonAbstract
    {
        public string  CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifierDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}