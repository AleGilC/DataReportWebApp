using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("tbl_AppUser", Schema="Security")]
    public class AppUser
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [EmailAddress]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }  

        public byte[] PasswordSalt { get; set; }
    }
}