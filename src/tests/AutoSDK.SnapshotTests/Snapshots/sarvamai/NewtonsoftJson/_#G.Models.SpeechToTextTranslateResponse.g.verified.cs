//HintName: G.Models.SpeechToTextTranslateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextTranslateResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Translated text in English
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Detected source language code (BCP-47)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextTranslateResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="transcript">
        /// Translated text in English
        /// </param>
        /// <param name="languageCode">
        /// Detected source language code (BCP-47)
        /// </param>
        public SpeechToTextTranslateResponse(
            string? requestId,
            string? transcript,
            string? languageCode)
        {
            this.RequestId = requestId;
            this.Transcript = transcript;
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextTranslateResponse" /> class.
        /// </summary>
        public SpeechToTextTranslateResponse()
        {
        }
    }
}