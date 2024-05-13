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
        public global::System.Collections.Generic.IList<TranscriptionSegment?>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}