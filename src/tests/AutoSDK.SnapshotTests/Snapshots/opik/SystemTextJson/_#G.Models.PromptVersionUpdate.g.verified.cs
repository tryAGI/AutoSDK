//HintName: G.Models.PromptVersionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update to apply to prompt versions.<br/>
    /// Note: Prompt versions are immutable by design.<br/>
    /// Only organizational properties (such as tags etc.) can be updated.<br/>
    /// Core properties like template, metadata etc. cannot be modified after creation.
    /// </summary>
    public sealed partial class PromptVersionUpdate
    {
        /// <summary>
        /// Tags to set or merge with existing tags. Follows PATCH semantics:<br/>
        /// - If merge_tags is true, these tags will be added to existing tags.<br/>
        /// - If merge_tags is false, these tags will replace all existing tags.<br/>
        /// - null: preserve existing tags (no change).<br/>
        /// - empty set: clear all tags when merge_tags is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionUpdate" /> class.
        /// </summary>
        /// <param name="tags">
        /// Tags to set or merge with existing tags. Follows PATCH semantics:<br/>
        /// - If merge_tags is true, these tags will be added to existing tags.<br/>
        /// - If merge_tags is false, these tags will replace all existing tags.<br/>
        /// - null: preserve existing tags (no change).<br/>
        /// - empty set: clear all tags when merge_tags is false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionUpdate(
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionUpdate" /> class.
        /// </summary>
        public PromptVersionUpdate()
        {
        }
    }
}