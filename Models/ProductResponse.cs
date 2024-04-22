using Newtonsoft.Json;

namespace TestServer.Models;

public class ProductResponse
{
    [JsonProperty("list")]
    public List<ProductItem> ProductList { get; set; } = new();
}