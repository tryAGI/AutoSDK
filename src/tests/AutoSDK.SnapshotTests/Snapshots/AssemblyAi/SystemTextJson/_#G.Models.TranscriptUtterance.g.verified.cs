//HintName: G.Models.TranscriptUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptUtterance
    {
        /// <summary>
        /// The confidence score for the transcript of this utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the utterance in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the utterance in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The text for this utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The words in the utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranscriptWord> Words { get; set; }

        /// <summary>
        /// The speaker of this utterance, where each speaker is assigned a sequential capital letter - e.g. "A" for Speaker A, "B" for Speaker B, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptUtterance" /> class.
        /// </summary>
        /// <param name="confidence">
        /// The confidence score for the transcript of this utterance
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the utterance in the audio file
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the utterance in the audio file
        /// </param>
        /// <param name="text">
        /// The text for this utterance
        /// </param>
        /// <param name="words">
        /// The words in the utterance.
        /// </param>
        /// <param name="speaker">
        /// The speaker of this utterance, where each speaker is assigned a sequential capital letter - e.g. "A" for Speaker A, "B" for Speaker B, etc.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptUtterance(
            double confidence,
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<global::G.TranscriptWord> words,
            string speaker)
        {
            this.Confidence = confidence;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptUtterance" /> class.
        /// </summary>
        public TranscriptUtterance()
        {
        }
    }
}