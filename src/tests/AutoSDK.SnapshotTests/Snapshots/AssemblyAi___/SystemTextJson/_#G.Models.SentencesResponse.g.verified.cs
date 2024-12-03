//HintName: G.Models.SentencesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentencesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranscriptSentence> Sentences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="confidence"></param>
        /// <param name="audioDuration"></param>
        /// <param name="sentences"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SentencesResponse(
            global::System.Guid id,
            double confidence,
            double audioDuration,
            global::System.Collections.Generic.IList<global::G.TranscriptSentence> sentences)
        {
            this.Id = id;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Sentences = sentences ?? throw new global::System.ArgumentNullException(nameof(sentences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        public SentencesResponse()
        {
        }
    }
}