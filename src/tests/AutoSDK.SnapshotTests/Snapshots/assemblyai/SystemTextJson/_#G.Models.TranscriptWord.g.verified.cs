//HintName: G.Models.TranscriptWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Word<br/>
    /// Example: {"text":"Smoke","start":250,"end":650,"confidence":0.97465,"speaker":""}
    /// </summary>
    public sealed partial class TranscriptWord
    {
        /// <summary>
        /// Confidence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Start
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// End
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public object? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWord" /> class.
        /// </summary>
        /// <param name="confidence">
        /// Confidence
        /// </param>
        /// <param name="start">
        /// Start
        /// </param>
        /// <param name="end">
        /// End
        /// </param>
        /// <param name="text">
        /// Text
        /// </param>
        /// <param name="speaker">
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptWord(
            double confidence,
            int start,
            int end,
            string text,
            object? speaker)
        {
            this.Confidence = confidence;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWord" /> class.
        /// </summary>
        public TranscriptWord()
        {
        }
    }
}