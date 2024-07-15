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
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Array of caches
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions_caches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActionsCacheListActionsCaches> ActionsCaches { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}