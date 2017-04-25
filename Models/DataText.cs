using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LR9.Models
{
    public class DataText
    {
        public int Id { get; set; }
        [Required]
        public string firstBox { get; set; }
        [Required]
        public string secondBox { get; set; }
        public string thirdBox { get; set; }
    }

    public class DataList
    {
        public static List<DataText> dataList = new List<DataText>();
    }
}
