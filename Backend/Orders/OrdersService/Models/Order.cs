using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersService.Models;

public class Order : BaseEntity
{
    [Required]
    public string SenderCity { get; set; }
    
    [Required]
    public string SenderAddress { get; set; }
    
    [Required]
    public string RecipientCity { get; set; }
    
    [Required]
    public string RecipientAddress { get; set; }
    
    [Required]
    public float CargoWeight { get; set; }
    
    [Required]
    [Column(TypeName = "date")]
    public DateTime CargoPickupDate { get; set; }
}