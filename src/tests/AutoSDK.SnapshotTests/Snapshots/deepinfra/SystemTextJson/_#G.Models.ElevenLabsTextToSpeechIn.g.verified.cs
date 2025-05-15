//HintName: G.Models.ElevenLabsTextToSpeechIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenLabsTextToSpeechIn
    {
        /// <summary>
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </summary>
        /// <example>
        /// I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Model ID to use for the conversion<br/>
        /// Default Value: hexgrad/Kokoro-82M
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
        /// Default Value: wav<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TtsResponseFormatJsonConverter))]
        public global::G.TtsResponseFormat? OutputFormat { get; set; }

        /// <summary>
        /// ISO 639-1, 2 letter language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsTextToSpeechIn" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </param>
        /// <param name="modelId">
        /// Model ID to use for the conversion<br/>
        /// Default Value: hexgrad/Kokoro-82M
        /// </param>
        /// <param name="outputFormat">
        /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
        /// Default Value: wav<br/>
        /// Example: mp3
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1, 2 letter language code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsTextToSpeechIn(
            string text,
            string? modelId,
            global::G.TtsResponseFormat? outputFormat,
            string? languageCode)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ModelId = modelId;
            this.OutputFormat = outputFormat;
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsTextToSpeechIn" /> class.
        /// </summary>
        public ElevenLabsTextToSpeechIn()
        {
        }
    }
}