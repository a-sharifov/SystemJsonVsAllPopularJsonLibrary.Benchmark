namespace SystemJsonVsAllPopularJsonLibrary.Benchmark.Benchmarks;

[MemoryDiagnoser]
public class DeserializeBenchmark
{
    private string _usersJsonString = null!;

    [GlobalSetup]
    public void Setup() => 
        _usersJsonString = File.ReadAllText(@"Templates\Users.Json");

    [Benchmark]
    public void SystemTextJson() =>
        System.Text.Json.JsonSerializer.Deserialize<List<User>>(_usersJsonString);

    [Benchmark]
    public void NewtonsoftJsonLibrary() =>
        Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(_usersJsonString);

    [Benchmark]
    public void Utf8JsonLibrary() =>
        Utf8Json.JsonSerializer.Deserialize<List<User>>(_usersJsonString);

    [Benchmark]
    public void SpanJsonLibrary() =>
       SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<User>>(_usersJsonString);
}
