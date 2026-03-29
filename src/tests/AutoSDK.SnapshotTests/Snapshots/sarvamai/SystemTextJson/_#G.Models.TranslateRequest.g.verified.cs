//HintName: G.Models.TranslateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateRequest
    {
        /// <summary>
        /// Text to translate (max 1000 chars for mayura:v1, 2000 for sarvam-translate:v1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Source language code (BCP-47) or "auto" for automatic detection with mayura:v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestSourceLanguageCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslateRequestSourceLanguageCode SourceLanguageCode { get; set; }

        /// <summary>
        /// Target language code (BCP-47)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestTargetLanguageCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslateRequestTargetLanguageCode TargetLanguageCode { get; set; }

        /// <summary>
        /// Gender of the speaker for better translations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestSpeakerGenderJsonConverter))]
        public global::G.TranslateRequestSpeakerGender? SpeakerGender { get; set; }

        /// <summary>
        /// Tone or style of the translation<br/>
        /// Default Value: formal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestModeJsonConverter))]
        public global::G.TranslateRequestMode? Mode { get; set; }

        /// <summary>
        /// Translation model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestModelJsonConverter))]
        public global::G.TranslateRequestModel? Model { get; set; }

        /// <summary>
        /// Controls transliteration style applied to the output text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestOutputScriptJsonConverter))]
        public global::G.TranslateRequestOutputScript? OutputScript { get; set; }

        /// <summary>
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerals_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestNumeralsFormatJsonConverter))]
        public global::G.TranslateRequestNumeralsFormat? NumeralsFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to translate (max 1000 chars for mayura:v1, 2000 for sarvam-translate:v1)
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Source language code (BCP-47) or "auto" for automatic detection with mayura:v1
        /// </param>
        /// <param name="targetLanguageCode">
        /// Target language code (BCP-47)
        /// </param>
        /// <param name="speakerGender">
        /// Gender of the speaker for better translations
        /// </param>
        /// <param name="mode">
        /// Tone or style of the translation<br/>
        /// Default Value: formal
        /// </param>
        /// <param name="model">
        /// Translation model to use
        /// </param>
        /// <param name="outputScript">
        /// Controls transliteration style applied to the output text
        /// </param>
        /// <param name="numeralsFormat">
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateRequest(
            string input,
            global::G.TranslateRequestSourceLanguageCode sourceLanguageCode,
            global::G.TranslateRequestTargetLanguageCode targetLanguageCode,
            global::G.TranslateRequestSpeakerGender? speakerGender,
            global::G.TranslateRequestMode? mode,
            global::G.TranslateRequestModel? model,
            global::G.TranslateRequestOutputScript? outputScript,
            global::G.TranslateRequestNumeralsFormat? numeralsFormat)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.SourceLanguageCode = sourceLanguageCode;
            this.TargetLanguageCode = targetLanguageCode;
            this.SpeakerGender = speakerGender;
            this.Mode = mode;
            this.Model = model;
            this.OutputScript = outputScript;
            this.NumeralsFormat = numeralsFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateRequest" /> class.
        /// </summary>
        public TranslateRequest()
        {
        }
    }
}