namespace SystemJsonVsAllPopularJsonLibrary.Benchmark.Models;

public class User
{
    public int id { get; set; } 
    public string name { get; set; } = null!;
    public string username { get; set; } = null!;
    public string email { get; set; } = null!;
    public Address address { get; set; } = null!;
    public string phone { get; set; } = null!;
    public string website { get; set; } = null!;
    public Company company { get; set; } = null!;
}
