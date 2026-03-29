//HintName: G.Models.AudioTranscriptionResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionResponse200
    {
        /// <summary>
        /// The transcribed audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The task used in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// The language of the audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The duration of the audio file in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// An array containing objects with segment level data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::G.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems>? Segments { get; set; }

        /// <summary>
        /// An array containing objects with word level data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::G.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionResponse200" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed audio.
        /// </param>
        /// <param name="task">
        /// The task used in the request.
        /// </param>
        /// <param name="language">
        /// The language of the audio file.
        /// </param>
        /// <param name="duration">
        /// The duration of the audio file in seconds.
        /// </param>
        /// <param name="segments">
        /// An array containing objects with segment level data.
        /// </param>
        /// <param name="words">
        /// An array containing objects with word level data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionResponse200(
            string? text,
            string? task,
            string? language,
            double? duration,
            global::System.Collections.Generic.IList<global::G.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems>? segments,
            global::System.Collections.Generic.IList<global::G.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems>? words)
        {
            this.Text = text;
            this.Task = task;
            this.Language = language;
            this.Duration = duration;
            this.Segments = segments;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionResponse200" /> class.
        /// </summary>
        public AudioTranscriptionResponse200()
        {
        }
    }
}