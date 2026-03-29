//HintName: G.Models.PromptVersionLinkPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionLinkPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        public global::System.Guid? PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public global::System.Guid? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        public string? PromptName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionLinkPublic" /> class.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="commit"></param>
        /// <param name="promptId"></param>
        /// <param name="promptName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionLinkPublic(
            global::System.Guid? promptVersionId,
            string? commit,
            global::System.Guid? promptId,
            string? promptName)
        {
            this.PromptVersionId = promptVersionId;
            this.Commit = commit;
            this.PromptId = promptId;
            this.PromptName = promptName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionLinkPublic" /> class.
        /// </summary>
        public PromptVersionLinkPublic()
        {
        }
    }
}