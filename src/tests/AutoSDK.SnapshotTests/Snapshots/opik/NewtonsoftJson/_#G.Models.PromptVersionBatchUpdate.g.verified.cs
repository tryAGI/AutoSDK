//HintName: G.Models.PromptVersionBatchUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update one or more prompt versions.<br/>
    /// Note: Prompt versions are immutable by design - only organizational properties (such as tags etc.) can be updated.
    /// </summary>
    public sealed partial class PromptVersionBatchUpdate
    {
        /// <summary>
        /// IDs of prompt versions to update
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> Ids { get; set; } = default!;

        /// <summary>
        /// Update to apply to prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties (such as tags etc.) can be updated.<br/>
        /// Core properties like template, metadata etc. cannot be modified after creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptVersionUpdate Update { get; set; } = default!;

        /// <summary>
        /// Tag merge behavior:<br/>
        /// - true: Add new tags to existing tags (union)<br/>
        /// - false: Replace all existing tags with new tags (default behaviour if not provided)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_tags")]
        public bool? MergeTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionBatchUpdate" /> class.
        /// </summary>
        /// <param name="ids">
        /// IDs of prompt versions to update
        /// </param>
        /// <param name="update">
        /// Update to apply to prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties (such as tags etc.) can be updated.<br/>
        /// Core properties like template, metadata etc. cannot be modified after creation.
        /// </param>
        /// <param name="mergeTags">
        /// Tag merge behavior:<br/>
        /// - true: Add new tags to existing tags (union)<br/>
        /// - false: Replace all existing tags with new tags (default behaviour if not provided)<br/>
        /// Default Value: false
        /// </param>
        public PromptVersionBatchUpdate(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.PromptVersionUpdate update,
            bool? mergeTags)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Update = update ?? throw new global::System.ArgumentNullException(nameof(update));
            this.MergeTags = mergeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionBatchUpdate" /> class.
        /// </summary>
        public PromptVersionBatchUpdate()
        {
        }
    }
}