namespace lab1_webapi_event.Entity;

public class Product
{
      public int Id { get; set; }
      public string Name { get; set; } = string.Empty;

      public string Description { get; set; } = string.Empty;
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
}