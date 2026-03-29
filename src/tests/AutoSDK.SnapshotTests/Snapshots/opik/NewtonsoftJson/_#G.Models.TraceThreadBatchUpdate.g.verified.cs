//HintName: G.Models.TraceThreadBatchUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to batch update multiple trace threads
    /// </summary>
    public sealed partial class TraceThreadBatchUpdate
    {
        /// <summary>
        /// List of thread model IDs to update (max 1000)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TraceThreadUpdate Update { get; set; } = default!;

        /// <summary>
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_tags")]
        public bool? MergeTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadBatchUpdate" /> class.
        /// </summary>
        /// <param name="ids">
        /// List of thread model IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
        public TraceThreadBatchUpdate(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.TraceThreadUpdate update,
            bool? mergeTags)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Update = update ?? throw new global::System.ArgumentNullException(nameof(update));
            this.MergeTags = mergeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadBatchUpdate" /> class.
        /// </summary>
        public TraceThreadBatchUpdate()
        {
        }
    }
}