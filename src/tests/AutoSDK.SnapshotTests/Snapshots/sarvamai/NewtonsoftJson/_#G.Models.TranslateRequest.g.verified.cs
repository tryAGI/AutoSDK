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
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Source language code (BCP-47) or "auto" for automatic detection with mayura:v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestSourceLanguageCodeJsonConverter))]
        public global::G.TranslateRequestSourceLanguageCode SourceLanguageCode { get; set; } = default!;

        /// <summary>
        /// Target language code (BCP-47)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestTargetLanguageCodeJsonConverter))]
        public global::G.TranslateRequestTargetLanguageCode TargetLanguageCode { get; set; } = default!;

        /// <summary>
        /// Gender of the speaker for better translations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_gender")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestSpeakerGenderJsonConverter))]
        public global::G.TranslateRequestSpeakerGender? SpeakerGender { get; set; }

        /// <summary>
        /// Tone or style of the translation<br/>
        /// Default Value: formal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestModeJsonConverter))]
        public global::G.TranslateRequestMode? Mode { get; set; }

        /// <summary>
        /// Translation model to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestModelJsonConverter))]
        public global::G.TranslateRequestModel? Model { get; set; }

        /// <summary>
        /// Controls transliteration style applied to the output text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_script")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestOutputScriptJsonConverter))]
        public global::G.TranslateRequestOutputScript? OutputScript { get; set; }

        /// <summary>
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numerals_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateRequestNumeralsFormatJsonConverter))]
        public global::G.TranslateRequestNumeralsFormat? NumeralsFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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