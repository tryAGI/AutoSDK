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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResearchDtoClass> Data { get; set; } = default!;

        /// <summary>
        /// Whether there are more results to paginate through
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasMore", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The cursor to paginate through the next set of results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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