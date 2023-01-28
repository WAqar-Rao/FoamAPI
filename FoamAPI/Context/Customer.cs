using System.ComponentModel.DataAnnotations.Schema;

namespace FoamAPI.Context
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
