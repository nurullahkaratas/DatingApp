using System;

namespace API.Entities
{
    public class Book
{
    public int Id { get; set; } 
    public int BookId { get; set; }
    public DateTime Created { get; set; }=DateTime.Now;
    public string Author { get; set; }
}
}