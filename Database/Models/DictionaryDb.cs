using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class DictionaryDb
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string PlWord { get; set; }
        public string EngWord { get; set; }
    }
}