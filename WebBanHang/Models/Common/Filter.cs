using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebBanHang.Models.Common
{
    public class Filter
    {
        private static readonly string strCheck = "àáảãạăằắẳẵặâầấẩẫậèéẻẽẹêềếểễệìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵ" +
                                          "ÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬÈÉẺẼẸÊỀẾỂỄỆÌÍỈĨỊÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢÙÚỦŨỤƯỪỨỬỮỰỲÝỶỸỴ~!@#$%^&*()_-+={[}]|\\/:;\"'<>,.?/";

        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "àáảãạăằắẳẵặâầấẩẫậ",
            "ÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬ",
            "èéẻẽẹêềếểễệ",
            "ÈÉẺẼẸÊỀẾỂỄỆ",
            "òóỏõọôồốổỗộơờớởỡợ",
            "ÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ",
            "ùúủũụưừứửữự",
            "ÙÚỦŨỤƯỪỨỬỮỰ",
            "ìíỉĩị",
            "ÌÍỈĨỊ",
            "đ",
            "Đ",
            "ỳýỷỹỵ",
            "ỲÝỶỸỴ"
        };

        public static string ChuyenCoDauThanhKhongDau(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            str = str.Trim();

            // Thay thế từng ký tự có dấu bằng ký tự không dấu tương ứng
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
            }

            return str;
        }

        /// <summary>
        /// Loại bỏ các ký tự đặc biệt khỏi chuỗi.
        /// </summary>
        public static string FilterChar(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            // Bước 1: Chuyển thành không dấu
            str = ChuyenCoDauThanhKhongDau(str);

            // Bước 2: Loại bỏ ký tự đặc biệt (chỉ giữ lại chữ cái, số, khoảng trắng)
            str = Regex.Replace(str, @"[^a-zA-Z0-9\s]", "");

            // Bước 3: Chuyển khoảng trắng thành dấu gạch ngang (-) và loại bỏ khoảng trắng thừa
            str = Regex.Replace(str, @"\s+", "-").Trim('-');

            return str.ToLower(); // Chuyển về chữ thường
        }

    }
}