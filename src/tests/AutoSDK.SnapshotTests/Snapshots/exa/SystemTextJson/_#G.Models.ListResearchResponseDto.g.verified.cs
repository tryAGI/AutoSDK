//HintName: G.Models.ListResearchResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResearchResponseDto
    {
        /// <summary>
        /// The list of research requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ResearchDtoClass> Data { get; set; }

        /// <summary>
        /// Whether there are more results to paginate through
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The cursor to paginate through the next set of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResearchResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of research requests
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results to paginate through
        /// </param>
        /// <param name="nextCursor">
        /// The cursor to paginate through the next set of results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResearchResponseDto(
            global::System.Collections.Generic.IList<global::G.ResearchDtoClass> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResearchResponseDto" /> class.
        /// </summary>
        public ListResearchResponseDto()
        {
        }
    }
}