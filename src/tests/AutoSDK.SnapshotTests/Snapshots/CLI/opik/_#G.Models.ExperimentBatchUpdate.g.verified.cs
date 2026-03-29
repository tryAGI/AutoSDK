//HintName: G.Models.ExperimentBatchUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to batch update multiple experiments
    /// </summary>
    public sealed partial class ExperimentBatchUpdate
    {
        /// <summary>
        /// List of experiment IDs to update (max 1000)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExperimentUpdate Update { get; set; }

        /// <summary>
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_tags")]
        public bool? MergeTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentBatchUpdate" /> class.
        /// </summary>
        /// <param name="ids">
        /// List of experiment IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentBatchUpdate(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.ExperimentUpdate update,
            bool? mergeTags)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Update = update ?? throw new global::System.ArgumentNullException(nameof(update));
            this.MergeTags = mergeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentBatchUpdate" /> class.
        /// </summary>
        public ExperimentBatchUpdate()
        {
        }
    }
}