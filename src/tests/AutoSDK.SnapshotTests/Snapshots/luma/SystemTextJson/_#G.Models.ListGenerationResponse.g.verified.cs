//HintName: G.Models.ListGenerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generations response object<br/>
    /// Example: {"has_more":false,"count":1,"limit":100,"offset":0,"generations":[{"id":"123e4567-e89b-12d3-a456-426614174000","state":"completed","failure_reason":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","created_at":"2023-06-01T12:00:00Z","assets":{"video":"https://example.com/video.mp4"},"version":"v1.6","request":{"prompt":"A serene lake surrounded by mountains at sunset","aspect_ratio":"16:9","loop":true,"keyframes":{"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}}}]}
    /// </summary>
    public sealed partial class ListGenerationResponse
    {
        /// <summary>
        /// Whether there are more generations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The number of generations returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

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
        /// The generations requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Generation> Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGenerationResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Whether there are more generations
        /// </param>
        /// <param name="count">
        /// The number of generations returned
        /// </param>
        /// <param name="limit">
        /// The limit of the generations requested
        /// </param>
        /// <param name="offset">
        /// The offset of the generations requested
        /// </param>
        /// <param name="generations">
        /// The generations requested
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGenerationResponse(
            global::System.Collections.Generic.IList<global::G.Generation> generations,
            bool? hasMore,
            int? count,
            int? limit,
            int? offset)
        {
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
            this.HasMore = hasMore;
            this.Count = count;
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