//HintName: G.Models.SpanBatchUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to batch update multiple spans
    /// </summary>
    public sealed partial class SpanBatchUpdate
    {
        /// <summary>
        /// List of span IDs to update (max 1000)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpanUpdate Update { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="SpanBatchUpdate" /> class.
        /// </summary>
        /// <param name="ids">
        /// List of span IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
        public SpanBatchUpdate(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.SpanUpdate update,
            bool? mergeTags)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Update = update ?? throw new global::System.ArgumentNullException(nameof(update));
            this.MergeTags = mergeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanBatchUpdate" /> class.
        /// </summary>
        public SpanBatchUpdate()
        {
        }
    }
}