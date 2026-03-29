//HintName: G.Models.ArchivalMemorySearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArchivalMemorySearchResponse
    {
        /// <summary>
        /// List of search results matching the query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ArchivalMemorySearchResult> Results { get; set; } = default!;

        /// <summary>
        /// Total number of results returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalMemorySearchResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// List of search results matching the query
        /// </param>
        /// <param name="count">
        /// Total number of results returned
        /// </param>
        public ArchivalMemorySearchResponse(
            global::System.Collections.Generic.IList<global::G.ArchivalMemorySearchResult> results,
            int count)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalMemorySearchResponse" /> class.
        /// </summary>
        public ArchivalMemorySearchResponse()
        {
        }
    }
}