//HintName: G.Models.PromptVersionLink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionLink
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public global::System.Guid? PromptId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        public string? PromptName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionLink" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="commit">
        /// Included only in responses
        /// </param>
        /// <param name="promptId">
        /// Included only in responses
        /// </param>
        /// <param name="promptName">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionLink(
            global::System.Guid id,
            string? commit,
            global::System.Guid? promptId,
            string? promptName)
        {
            this.Id = id;
            this.Commit = commit;
            this.PromptId = promptId;
            this.PromptName = promptName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionLink" /> class.
        /// </summary>
        public PromptVersionLink()
        {
        }
    }
}