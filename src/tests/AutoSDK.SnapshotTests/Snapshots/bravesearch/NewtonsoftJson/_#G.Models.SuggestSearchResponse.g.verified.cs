//HintName: G.Models.SuggestSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from the suggest/autocomplete endpoint.
    /// </summary>
    public sealed partial class SuggestSearchResponse
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Information about the original search query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public global::G.Query? Query { get; set; }

        /// <summary>
        /// List of autocomplete suggestions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.SuggestResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestSearchResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="query">
        /// Information about the original search query.
        /// </param>
        /// <param name="results">
        /// List of autocomplete suggestions.
        /// </param>
        public SuggestSearchResponse(
            string? type,
            global::G.Query? query,
            global::System.Collections.Generic.IList<global::G.SuggestResult>? results)
        {
            this.Type = type;
            this.Query = query;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestSearchResponse" /> class.
        /// </summary>
        public SuggestSearchResponse()
        {
        }
    }
}