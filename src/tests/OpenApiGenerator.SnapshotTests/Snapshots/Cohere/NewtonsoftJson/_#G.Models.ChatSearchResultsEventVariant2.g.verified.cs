//HintName: G.Models.ChatSearchResultsEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchResultsEventVariant2
    {
        /// <summary>
        /// Conducted searches and the ids of documents retrieved from each of them.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_results")]
        public global::System.Collections.Generic.IList<global::G.ChatSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Documents fetched from searches or provided by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.ChatDocument>? Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}