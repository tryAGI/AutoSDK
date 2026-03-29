//HintName: G.Models.SearchWebResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchWebResponse
    {
        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestId", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// The search query that was executed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// List of search results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchWebResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="query">
        /// The search query that was executed
        /// </param>
        /// <param name="results">
        /// List of search results
        /// </param>
        public SearchWebResponse(
            string requestId,
            string query,
            global::System.Collections.Generic.IList<global::G.SearchWebResponseResult> results)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebResponse" /> class.
        /// </summary>
        public SearchWebResponse()
        {
        }
    }
}