using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("tbl_AppUser", Schema="Security")]
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }
    }
}