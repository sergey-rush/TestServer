using Newtonsoft.Json;

namespace RuRuServer.Models;

public class ProductRequest
{
    /// <summary>
    /// Логин, выданный системе партнера.
    /// </summary>
    [JsonProperty("appID")]
    public string AppID { get; set; }

    /// <summary>
    /// Tокен доступа
    /// </summary>
    [JsonProperty("token")]
    public string Token { get; set; }

    /// <summary>
    /// Телефон клиента в любом допустимом формате. Например, '79099090000'.
    /// </summary>
    [JsonProperty("phone")]
    public string Phone { get; set; }
}