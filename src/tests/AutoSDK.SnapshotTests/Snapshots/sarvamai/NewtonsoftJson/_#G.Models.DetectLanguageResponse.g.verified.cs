//HintName: G.Models.DetectLanguageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectLanguageResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Detected language code (BCP-47)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Detected script code (e.g., Latn, Deva, Beng, Gujr, Knda, Mlym, Orya, Guru, Taml, Telu)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script_code")]
        public string? ScriptCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="languageCode">
        /// Detected language code (BCP-47)
        /// </param>
        /// <param name="scriptCode">
        /// Detected script code (e.g., Latn, Deva, Beng, Gujr, Knda, Mlym, Orya, Guru, Taml, Telu)
        /// </param>
        public DetectLanguageResponse(
            string? requestId,
            string? languageCode,
            string? scriptCode)
        {
            this.RequestId = requestId;
            this.LanguageCode = languageCode;
            this.ScriptCode = scriptCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageResponse" /> class.
        /// </summary>
        public DetectLanguageResponse()
        {
        }
    }
}