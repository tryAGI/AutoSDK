//HintName: G.Models.InsightPaginatedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightPaginatedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Insight> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PaginationMeta Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightPaginatedResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="metadata"></param>
        public InsightPaginatedResponse(
            global::System.Collections.Generic.IList<global::G.Insight> results,
            global::G.PaginationMeta metadata)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightPaginatedResponse" /> class.
        /// </summary>
        public InsightPaginatedResponse()
        {
        }
    }
}