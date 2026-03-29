//HintName: G.Models.SearchWebRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchWebRequest
    {
        /// <summary>
        /// The search query string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string
        /// </param>
        /// <param name="numResults">
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </param>
        public SearchWebRequest(
            string query,
            int? numResults)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.NumResults = numResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequest" /> class.
        /// </summary>
        public SearchWebRequest()
        {
        }
    }
}