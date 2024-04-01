using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEF.Entities;

[Table(name:"m_customer")]
public class Customer
{
    [Key, Column(name:"id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column(name:"customer_name", TypeName = "NVarchar(50)"), Required]
    public string CustomerName { get; set; }
    
    [Column(name:"address", TypeName = "NVarchar(250)"), Required]
    public string Address { get; set; }
    
    [Column(name:"mobile_phone", TypeName = "NVarchar(14)")]
    public string MobilePhone { get; set; }
    
    [Column(name:"email", TypeName = "NVarchar(50)")]
    public string Email { get; set; }
}