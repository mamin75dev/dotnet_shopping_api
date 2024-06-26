namespace ShoppingApi.Data.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }
    public DateTime EndOfDiscount { get; set; }
    public string[] Colors { get; set; }
    public string[] Options { get; set; }
    public string? Weight { get; set; }
    public string? BodyMaterial { get; set; }
    public string Model { get; set; }
    public DateTime IntroductionDate { get; set; }
    public string Images { get; set; }
    public int CategoryId { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public Category Category { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastUpdatedDate { get; set; }
}