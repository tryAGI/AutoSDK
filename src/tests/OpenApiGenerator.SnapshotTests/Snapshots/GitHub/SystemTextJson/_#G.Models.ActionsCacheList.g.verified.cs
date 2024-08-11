//HintName: G.Models.ActionsCacheList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository actions caches
    /// </summary>
    public sealed partial class ActionsCacheList
    {
        /// <summary>
        /// Total number of caches<br/>
        /// Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Array of caches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_caches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ActionsCacheListActionsCache> ActionsCaches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}