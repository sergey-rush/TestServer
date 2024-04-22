using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TestServer.Models
{
    /// <summary>
    /// 5.1 Получение пользовательского токена
    /// URL: POST /v2/game/token
    /// </summary>
    public class TokenRequest
    {
        /// <summary>
        /// Логин, выданный системе партнера.
        /// </summary>
        [JsonProperty("appID")]
        public string AppID { get; set; }

        /// <summary>
        /// Телефон клиента в любом допустимом формате. Например, '79099090000'.
        /// </summary>
        [Required]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Время запроса. Рекомендуемый формат - ISO8601, например: 2022-09-01T10:00:00+03:00.
        /// </summary>
        [JsonProperty("time")]
        public DateTime RequestTime { get; set; }

        /// <summary>
        /// Подпись параметров в запросе.
        /// Каждый запрос подписан подписью (signature), которая передается в методы Gamification API в теле запроса.
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }
    }
}
