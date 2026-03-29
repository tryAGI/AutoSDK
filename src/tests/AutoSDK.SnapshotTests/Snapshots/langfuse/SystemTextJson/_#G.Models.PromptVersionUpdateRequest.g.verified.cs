//HintName: G.Models.PromptVersionUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionUpdateRequest
    {
        /// <summary>
        /// New labels for the prompt version. Labels are unique across versions. The "latest" label is reserved and managed by Langfuse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newLabels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NewLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionUpdateRequest" /> class.
        /// </summary>
        /// <param name="newLabels">
        /// New labels for the prompt version. Labels are unique across versions. The "latest" label is reserved and managed by Langfuse.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionUpdateRequest(
            global::System.Collections.Generic.IList<string> newLabels)
        {
            this.NewLabels = newLabels ?? throw new global::System.ArgumentNullException(nameof(newLabels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionUpdateRequest" /> class.
        /// </summary>
        public PromptVersionUpdateRequest()
        {
        }
    }
}