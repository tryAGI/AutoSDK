//HintName: G.Models.CreateTranslationResponseVerboseJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationResponseVerboseJson
    {
        /// <summary>
        /// The language of the output translation (always `english`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The duration of the input audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public string Duration { get; set; } = default!;

        /// <summary>
        /// The translated text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Segments of the translated text and their corresponding details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseVerboseJson" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the output translation (always `english`).
        /// </param>
        /// <param name="duration">
        /// The duration of the input audio.
        /// </param>
        /// <param name="text">
        /// The translated text.
        /// </param>
        /// <param name="segments">
        /// Segments of the translated text and their corresponding details.
        /// </param>
        public CreateTranslationResponseVerboseJson(
            string language,
            string duration,
            string text,
            global::System.Collections.Generic.IList<global::G.TranscriptionSegment>? segments)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseVerboseJson" /> class.
        /// </summary>
        public CreateTranslationResponseVerboseJson()
        {
        }
    }
}