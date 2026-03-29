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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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