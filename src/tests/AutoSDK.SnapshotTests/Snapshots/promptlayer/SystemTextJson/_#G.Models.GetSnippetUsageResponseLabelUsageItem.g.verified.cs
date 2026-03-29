//HintName: G.Models.GetSnippetUsageResponseLabelUsageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSnippetUsageResponseLabelUsageItem
    {
        /// <summary>
        /// The ID of the prompt with a label using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_registry_id")]
        public int? PromptRegistryId { get; set; }

        /// <summary>
        /// The name of the prompt with a label using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The name of the label using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_name")]
        public string? LabelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSnippetUsageResponseLabelUsageItem" /> class.
        /// </summary>
        /// <param name="promptRegistryId">
        /// The ID of the prompt with a label using this snippet
        /// </param>
        /// <param name="promptName">
        /// The name of the prompt with a label using this snippet
        /// </param>
        /// <param name="labelName">
        /// The name of the label using this snippet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSnippetUsageResponseLabelUsageItem(
            int? promptRegistryId,
            string? promptName,
            string? labelName)
        {
            this.PromptRegistryId = promptRegistryId;
            this.PromptName = promptName;
            this.LabelName = labelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSnippetUsageResponseLabelUsageItem" /> class.
        /// </summary>
        public GetSnippetUsageResponseLabelUsageItem()
        {
        }
    }
}