//HintName: G.Models.TranscriptionSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionSegment
    {
        /// <summary>
        /// Unique identifier of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Seek offset of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seek")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seek { get; set; }

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// Text content of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Array of token IDs for the text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Tokens { get; set; }

        /// <summary>
        /// Temperature parameter used for generating the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Temperature { get; set; }

        /// <summary>
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float AvgLogprob { get; set; }

        /// <summary>
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float CompressionRatio { get; set; }

        /// <summary>
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_speech_prob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float NoSpeechProb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the segment.
        /// </param>
        /// <param name="seek">
        /// Seek offset of the segment.
        /// </param>
        /// <param name="start">
        /// Start time of the segment in seconds.
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds.
        /// </param>
        /// <param name="text">
        /// Text content of the segment.
        /// </param>
        /// <param name="tokens">
        /// Array of token IDs for the text content.
        /// </param>
        /// <param name="temperature">
        /// Temperature parameter used for generating the segment.
        /// </param>
        /// <param name="avgLogprob">
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </param>
        /// <param name="compressionRatio">
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </param>
        /// <param name="noSpeechProb">
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptionSegment(
            int id,
            int seek,
            float start,
            float end,
            string text,
            global::System.Collections.Generic.IList<int> tokens,
            float temperature,
            float avgLogprob,
            float compressionRatio,
            float noSpeechProb)
        {
            this.Id = id;
            this.Seek = seek;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.Temperature = temperature;
            this.AvgLogprob = avgLogprob;
            this.CompressionRatio = compressionRatio;
            this.NoSpeechProb = noSpeechProb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSegment" /> class.
        /// </summary>
        public TranscriptionSegment()
        {
        }
    }
}