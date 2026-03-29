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
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ArchivalMemorySearchResult> Results { get; set; }

        /// <summary>
        /// Total number of results returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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