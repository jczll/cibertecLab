namespace Chinook.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Users")]
    public partial class Users
    {
        [Key]
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [DataMember]
        [Required]
        [StringLength(10)]
        public string Login { get; set; }

        [DataMember]
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
    }
}
