using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_Parcial2_Sergio_Lopez.Models
{
    public class Friend
    {
        [Key]
        public int FrienId { get; set; }
        [Required]
        public string Name { get; set; }
        public string NickName { get; set; }
        public DataType MyProperty { get; set; }
    }
}