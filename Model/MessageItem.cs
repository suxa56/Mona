using System.ComponentModel.DataAnnotations;

namespace Mona.Model;

public class MessageItem
{
    public int Id { get; set; }
    [Required]
    [MaxLength(256)]
    public string Text { get; set; } = string.Empty;
}