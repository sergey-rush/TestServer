using Newtonsoft.Json;

namespace RuRuServer.Models
{
    /// <summary>
    /// Маркер доступа и обновления
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        /// Токен, например fa475c0a45ab2f57055db900a7b3417f05384fdd
        /// </summary>
        [JsonProperty("token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Время жизни токена в секундах, например 1800
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

    }
}
