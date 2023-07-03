using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int DetailsId { get; set; }
        [ForeignKey("DetailsId")]
        public Details? Details { get; set; }
        public Type Type { get; set; }
    }
    public class Details
    {
        public int Id { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
    public enum Type
    {
        None = 0,
        Silver = 1,
        Gold = 2
    }
}
