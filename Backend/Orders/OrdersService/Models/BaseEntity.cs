using System.ComponentModel.DataAnnotations;

namespace OrdersService.Models;

public abstract class BaseEntity
{
    [Required]
    public int Id { get; set; }   
}