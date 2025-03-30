//HintName: G.Models.ListQueryHistoriesResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The metadata for the list of query histories.
    /// </summary>
    public sealed partial class ListQueryHistoriesResponseMetadata
    {
        /// <summary>
        /// A query parameter required when requesting the next page of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_key")]
        public string? PageKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListQueryHistoriesResponseMetadata" /> class.
        /// </summary>
        /// <param name="pageKey">
        /// A query parameter required when requesting the next page of results.
        /// </param>
        public ListQueryHistoriesResponseMetadata(
            string? pageKey)
        {
            this.PageKey = pageKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListQueryHistoriesResponseMetadata" /> class.
        /// </summary>
        public ListQueryHistoriesResponseMetadata()
        {
        }
    }
}