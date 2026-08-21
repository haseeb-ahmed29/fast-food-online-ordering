using System.ComponentModel.DataAnnotations;
namespace FastFoodOnlineOrdering.Models;
public class Category
{
 public int Id {get;set;}
 [Required, StringLength(140)] public string CategoryName {get;set;} = string.Empty;
 [Required, StringLength(120)] public string MealType {get;set;} = string.Empty;
 public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
}
