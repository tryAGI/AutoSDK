//HintName: G.Models.TranscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionResponse
    {
        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The specified language of the input audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The duration of the input audio in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Word-level timestamps showing the start and end time of each word. Only included when `[word]` is passed into `timestamp_granularities[]`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
        /// <param name="language">
        /// The specified language of the input audio.
        /// </param>
        /// <param name="duration">
        /// The duration of the input audio in seconds.
        /// </param>
        /// <param name="words">
        /// Word-level timestamps showing the start and end time of each word. Only included when `[word]` is passed into `timestamp_granularities[]`.
        /// </param>
        public TranscriptionResponse(
            string text,
            string? language,
            double? duration,
            global::System.Collections.Generic.IList<global::G.TranscriptionWord>? words)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Language = language;
            this.Duration = duration;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        public TranscriptionResponse()
        {
        }
    }
}