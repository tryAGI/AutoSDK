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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; } = "my search query";

        /// <summary>
        /// The minimum search relevance score required to include the result. By default, this is 10.0.<br/>
        /// Default Value: 10.0<br/>
        /// Example: 10.0
        /// </summary>
        /// <example>10.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance")]
        public float? Relevance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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