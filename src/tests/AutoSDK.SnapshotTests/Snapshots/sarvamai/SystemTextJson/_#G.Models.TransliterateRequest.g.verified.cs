//HintName: G.Models.TransliterateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransliterateRequest
    {
        /// <summary>
        /// Text to transliterate (max 1000 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Source language code (BCP-47) or "auto"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransliterateRequestSourceLanguageCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransliterateRequestSourceLanguageCode SourceLanguageCode { get; set; }

        /// <summary>
        /// Target language code (BCP-47)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransliterateRequestTargetLanguageCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransliterateRequestTargetLanguageCode TargetLanguageCode { get; set; }

        /// <summary>
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerals_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransliterateRequestNumeralsFormatJsonConverter))]
        public global::G.TransliterateRequestNumeralsFormat? NumeralsFormat { get; set; }

        /// <summary>
        /// Whether to convert text into a natural spoken form<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spoken_form")]
        public bool? SpokenForm { get; set; }

        /// <summary>
        /// Language for spoken form numerals (only applies when spoken_form is true)<br/>
        /// Default Value: native
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spoken_form_numerals_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransliterateRequestSpokenFormNumeralsLanguageJsonConverter))]
        public global::G.TransliterateRequestSpokenFormNumeralsLanguage? SpokenFormNumeralsLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterateRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to transliterate (max 1000 characters)
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Source language code (BCP-47) or "auto"
        /// </param>
        /// <param name="targetLanguageCode">
        /// Target language code (BCP-47)
        /// </param>
        /// <param name="numeralsFormat">
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </param>
        /// <param name="spokenForm">
        /// Whether to convert text into a natural spoken form<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spokenFormNumeralsLanguage">
        /// Language for spoken form numerals (only applies when spoken_form is true)<br/>
        /// Default Value: native
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransliterateRequest(
            string input,
            global::G.TransliterateRequestSourceLanguageCode sourceLanguageCode,
            global::G.TransliterateRequestTargetLanguageCode targetLanguageCode,
            global::G.TransliterateRequestNumeralsFormat? numeralsFormat,
            bool? spokenForm,
            global::G.TransliterateRequestSpokenFormNumeralsLanguage? spokenFormNumeralsLanguage)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.SourceLanguageCode = sourceLanguageCode;
            this.TargetLanguageCode = targetLanguageCode;
            this.NumeralsFormat = numeralsFormat;
            this.SpokenForm = spokenForm;
            this.SpokenFormNumeralsLanguage = spokenFormNumeralsLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterateRequest" /> class.
        /// </summary>
        public TransliterateRequest()
        {
        }
    }
}