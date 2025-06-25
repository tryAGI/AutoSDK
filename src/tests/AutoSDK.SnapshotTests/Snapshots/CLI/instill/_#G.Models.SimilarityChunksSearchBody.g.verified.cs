//HintName: G.Models.SimilarityChunksSearchBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityChunksSearchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textPrompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchBody" /> class.
        /// </summary>
        /// <param name="textPrompt"></param>
        /// <param name="topK"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityChunksSearchBody(
            string? textPrompt,
            long? topK)
        {
            this.TextPrompt = textPrompt;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchBody" /> class.
        /// </summary>
        public SimilarityChunksSearchBody()
        {
        }
    }
}