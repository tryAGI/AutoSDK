//HintName: G.Models.WordDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordDTO
    {
        /// <summary>
        /// Spoken word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Start timestamps in seconds of the spoken word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End timestamps in seconds of the spoken word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Confidence on the transcribed word (1 = 100% confident)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDTO" /> class.
        /// </summary>
        /// <param name="word">
        /// Spoken word
        /// </param>
        /// <param name="start">
        /// Start timestamps in seconds of the spoken word
        /// </param>
        /// <param name="end">
        /// End timestamps in seconds of the spoken word
        /// </param>
        /// <param name="confidence">
        /// Confidence on the transcribed word (1 = 100% confident)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordDTO(
            string word,
            double start,
            double end,
            double confidence)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDTO" /> class.
        /// </summary>
        public WordDTO()
        {
        }
    }
}