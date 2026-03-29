//HintName: G.Models.PromptTemplatesLabelsPromptLabelIdPatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptTemplatesLabelsPromptLabelIdPatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplatesLabelsPromptLabelIdPatchRequest" /> class.
        /// </summary>
        /// <param name="promptVersionNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptTemplatesLabelsPromptLabelIdPatchRequest(
            int promptVersionNumber)
        {
            this.PromptVersionNumber = promptVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplatesLabelsPromptLabelIdPatchRequest" /> class.
        /// </summary>
        public PromptTemplatesLabelsPromptLabelIdPatchRequest()
        {
        }
    }
}