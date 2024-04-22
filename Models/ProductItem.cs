using Newtonsoft.Json;
using TestServer.Base;

namespace TestServer.Models;

public class ProductItem
{
    /// <summary>
    /// ID продукта
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; } = 364;

    /// <summary>
    /// Наименование продукта
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = "Увеличение ежедневного лимита бросков на 30 на 7 дней";

    /// <summary>
    /// Техническое наименование продукта
    /// </summary>
    [JsonProperty("technical_name")]
    public string TechName { get; set; } = "Uvelichenie_Limit_broskov_30_7";

    /// <summary>
    /// Описание продукта
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; } = "Бустер на увеличение ежедневного лимита бросков на 30 на 7 дней";

    /// <summary>
    /// Стоимость продукта в рублях
    /// </summary>
    [JsonProperty("price")]
    public float Price { get; set; } = 1;

    /// <summary>
    /// Скидка в рублях
    /// </summary>
    [JsonProperty("discount")]
    public float Discount { get; set; } = 0;

    /// <summary>
    /// Цена со скидкой, в рублях
    /// </summary>
    [JsonProperty("priceWithDiscount")]
    public float PriceWithDiscount { get; set; } = 1;

    /// <summary>
    /// Дополнительные параметры продукта
    /// </summary>
    [JsonProperty("options")]
    public List<Option> Options { get; set; } = new List<Option>() { new Option() };

    /// <summary>
    /// Отключение из-за задолженности - возможность покупки заблокирована
    /// </summary>
    [JsonProperty("disabledDueToDebts")]
    public bool DisabledDueToDebts { get; set; }

    /// <summary>
    /// Игра, к которой относится продукт
    /// </summary>
    [JsonProperty("game")]
    public Game Game { get; set; } = new Game();
}