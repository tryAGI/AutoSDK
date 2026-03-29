//HintName: G.Models.SearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// The search query to be used to find relevant documentation.<br/>
        /// Default Value: my search query<br/>
        /// Example: my search query
        /// </summary>
        /// <default>"my search query"</default>
        /// <example>my search query</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The minimum search relevance score required to include the result. By default, this is 10.0.<br/>
        /// Default Value: 10.0<br/>
        /// Example: 10.0
        /// </summary>
        /// <example>10.0</example>
        [global::Newtonsoft.Json.JsonProperty("relevance")]
        public float? Relevance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query to be used to find relevant documentation.<br/>
        /// Default Value: my search query<br/>
        /// Example: my search query
        /// </param>
        /// <param name="relevance">
        /// The minimum search relevance score required to include the result. By default, this is 10.0.<br/>
        /// Default Value: 10.0<br/>
        /// Example: 10.0
        /// </param>
        public SearchRequest(
            string query,
            float? relevance)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Relevance = relevance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }
    }
}