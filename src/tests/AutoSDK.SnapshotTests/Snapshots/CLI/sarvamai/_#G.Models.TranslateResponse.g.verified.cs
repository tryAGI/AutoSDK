//HintName: G.Models.TranslateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Translated text in the target language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_text")]
        public string? TranslatedText { get; set; }

        /// <summary>
        /// Detected or provided source language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_code")]
        public string? SourceLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="translatedText">
        /// Translated text in the target language
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Detected or provided source language code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateResponse(
            string? requestId,
            string? translatedText,
            string? sourceLanguageCode)
        {
            this.RequestId = requestId;
            this.TranslatedText = translatedText;
            this.SourceLanguageCode = sourceLanguageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateResponse" /> class.
        /// </summary>
        public TranslateResponse()
        {
        }
    }
}