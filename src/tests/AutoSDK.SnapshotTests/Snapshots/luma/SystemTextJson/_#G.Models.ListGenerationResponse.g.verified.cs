//HintName: G.Models.ListGenerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generations response object
    /// </summary>
    public sealed partial class ListGenerationResponse
    {
        /// <summary>
        /// The number of generations returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// The generations requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Generation> Generations { get; set; }

        /// <summary>
        /// Whether there are more generations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The limit of the generations requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The offset of the generations requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGenerationResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of generations returned
        /// </param>
        /// <param name="generations">
        /// The generations requested
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more generations
        /// </param>
        /// <param name="limit">
        /// The limit of the generations requested
        /// </param>
        /// <param name="offset">
        /// The offset of the generations requested
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGenerationResponse(
            global::System.Collections.Generic.IList<global::G.Generation> generations,
            int? count,
            bool? hasMore,
            int? limit,
            int? offset)
        {
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
            this.Count = count;
            this.HasMore = hasMore;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGenerationResponse" /> class.
        /// </summary>
        public ListGenerationResponse()
        {
        }
    }
}