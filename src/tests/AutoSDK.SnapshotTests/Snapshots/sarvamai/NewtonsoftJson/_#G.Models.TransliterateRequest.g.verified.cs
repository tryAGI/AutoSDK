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
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Source language code (BCP-47) or "auto"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransliterateRequestSourceLanguageCode SourceLanguageCode { get; set; } = default!;

        /// <summary>
        /// Target language code (BCP-47)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransliterateRequestTargetLanguageCode TargetLanguageCode { get; set; } = default!;

        /// <summary>
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numerals_format")]
        public global::G.TransliterateRequestNumeralsFormat? NumeralsFormat { get; set; }

        /// <summary>
        /// Whether to convert text into a natural spoken form<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spoken_form")]
        public bool? SpokenForm { get; set; }

        /// <summary>
        /// Language for spoken form numerals (only applies when spoken_form is true)<br/>
        /// Default Value: native
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spoken_form_numerals_language")]
        public global::G.TransliterateRequestSpokenFormNumeralsLanguage? SpokenFormNumeralsLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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