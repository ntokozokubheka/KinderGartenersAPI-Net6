using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KindergartenAPI.Models
{

    [Table("Children")]
    public class ChildModel 
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ChildId { get; set; }
   
             [Required]
            [Column(TypeName = "nvarchar(250)")]
            public string Name{ get; set; }="";
            public int ContactNumber { get; set; }
            public int age { get; set; }

        

    }
}
