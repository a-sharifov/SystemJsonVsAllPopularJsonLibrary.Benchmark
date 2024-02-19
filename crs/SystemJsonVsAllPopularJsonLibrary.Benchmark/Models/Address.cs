namespace SystemJsonVsAllPopularJsonLibrary.Benchmark.Models;

public class Address
{
    public string street { get; set; } = null!;
    public string suite { get; set; } = null!;
    public string city { get; set; } = null!;
    public string zipcode { get; set; } = null!;
    public Geo geo { get; set; } = null!;
}
