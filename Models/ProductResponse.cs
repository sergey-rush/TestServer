using Newtonsoft.Json;

namespace RuRuServer.Models;

public class ProductResponse
{
    [JsonProperty("list")]
    public List<ProductItem> ProductList { get; set; } = new();
}