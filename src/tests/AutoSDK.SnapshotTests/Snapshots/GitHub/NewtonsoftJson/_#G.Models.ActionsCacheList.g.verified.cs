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
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Array of caches
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions_caches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActionsCacheListActionsCache> ActionsCaches { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheList" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Total number of caches<br/>
        /// Example: 2
        /// </param>
        /// <param name="actionsCaches">
        /// Array of caches
        /// </param>
        public ActionsCacheList(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.ActionsCacheListActionsCache> actionsCaches)
        {
            this.TotalCount = totalCount;
            this.ActionsCaches = actionsCaches ?? throw new global::System.ArgumentNullException(nameof(actionsCaches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheList" /> class.
        /// </summary>
        public ActionsCacheList()
        {
        }
    }
}