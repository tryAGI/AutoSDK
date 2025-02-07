//HintName: G.Models.SimilarityChunksSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityChunksSearchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarChunks")]
        public global::System.Collections.Generic.IList<global::G.SimilarityChunk>? SimilarChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchResponse" /> class.
        /// </summary>
        /// <param name="similarChunks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityChunksSearchResponse(
            global::System.Collections.Generic.IList<global::G.SimilarityChunk>? similarChunks)
        {
            this.SimilarChunks = similarChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchResponse" /> class.
        /// </summary>
        public SimilarityChunksSearchResponse()
        {
        }
    }
}