using Newtonsoft.Json;

namespace RuRuServer.Base;

public class Option
{
    [JsonProperty("PARTNER_PRODUCT_CODE")] 
    public string? PartnerProductCode { get; set; } = null;

    
    [JsonProperty("PARTNER_PROMO_PRODUCT_CODE")]
    public string? PartnerPromoProductCode { get; set; } = null;
}