using Newtonsoft.Json;

namespace RuRuServer.Base;

public class Game
{
    /// <summary>
    /// Наименование продукта
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = "Игра1";

    /// <summary>
    /// Техническое наименование продукта
    /// </summary>
    [JsonProperty("tech_name")]
    public string TechName { get; set; } = "igra1";
}