//HintName: G.Models.GraphsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Graph> Data { get; set; } = default!;

        /// <summary>
        /// The ID of the first Knowledge Graph in the current response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id")]
        public global::System.Guid? FirstId { get; set; }

        /// <summary>
        /// The ID of the last Knowledge Graph in the current response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id")]
        public global::System.Guid? LastId { get; set; }

        /// <summary>
        /// Indicates if there are more Knowledge Graphs available beyond the current page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// Indicates if there are more Knowledge Graphs available beyond the current page.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first Knowledge Graph in the current response.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last Knowledge Graph in the current response.
        /// </param>
        public GraphsResponse(
            global::System.Collections.Generic.IList<global::G.Graph> data,
            bool hasMore,
            global::System.Guid? firstId,
            global::System.Guid? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphsResponse" /> class.
        /// </summary>
        public GraphsResponse()
        {
        }
    }
}