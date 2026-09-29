using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace SupportWebApp.Models;

public class SupportMessage
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    public string ContactName { get; set; } = "";

    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public string Phone { get; set; } = "";

    [Required]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; } = "";
}