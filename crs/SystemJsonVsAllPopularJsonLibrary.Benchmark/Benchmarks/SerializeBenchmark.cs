namespace SystemJsonVsAllPopularJsonLibrary.Benchmark.Benchmarks;

[MemoryDiagnoser]
public class SerializeBenchmark
{
    private List<User> _users = null!;

    [GlobalSetup]
    public void Setup()
    {
        var usersJson = File.ReadAllText(@"Templates\Users.Json");
        _users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(usersJson)!;
    }

    [Benchmark]
    public void SystemTextJson() =>
        System.Text.Json.JsonSerializer.Serialize(_users);

    [Benchmark]
    public void NewtonsoftJsonLibrary() =>
        Newtonsoft.Json.JsonConvert.SerializeObject(_users);

    [Benchmark]
    public void Utf8JsonLibrary() =>
        Utf8Json.JsonSerializer.Serialize(_users);

    [Benchmark]
    public void SpanJsonLibrary() =>
       SpanJson.JsonSerializer.Generic.Utf16.Serialize(_users);
}
