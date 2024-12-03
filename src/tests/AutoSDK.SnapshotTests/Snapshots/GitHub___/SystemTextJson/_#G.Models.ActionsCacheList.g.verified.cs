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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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