//HintName: G.Models.TransliterateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransliterateResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Transliterated text in the target language script
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transliterated_text")]
        public string? TransliteratedText { get; set; }

        /// <summary>
        /// Detected or provided source language code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language_code")]
        public string? SourceLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterateResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="transliteratedText">
        /// Transliterated text in the target language script
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Detected or provided source language code
        /// </param>
        public TransliterateResponse(
            string? requestId,
            string? transliteratedText,
            string? sourceLanguageCode)
        {
            this.RequestId = requestId;
            this.TransliteratedText = transliteratedText;
            this.SourceLanguageCode = sourceLanguageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterateResponse" /> class.
        /// </summary>
        public TransliterateResponse()
        {
        }
    }
}