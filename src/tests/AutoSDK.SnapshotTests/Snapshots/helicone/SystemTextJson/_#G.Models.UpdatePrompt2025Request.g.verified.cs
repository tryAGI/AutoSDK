//HintName: G.Models.UpdatePrompt2025Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePrompt2025Request
    {
        /// <summary>
        /// Simplified interface for the OpenAI Chat request format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIChatRequest PromptBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newMajorVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NewMajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrompt2025Request" /> class.
        /// </summary>
        /// <param name="promptBody">
        /// Simplified interface for the OpenAI Chat request format
        /// </param>
        /// <param name="commitMessage"></param>
        /// <param name="newMajorVersion"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptId"></param>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrompt2025Request(
            global::G.OpenAIChatRequest promptBody,
            string commitMessage,
            bool newMajorVersion,
            string promptVersionId,
            string promptId,
            string? environment)
        {
            this.PromptBody = promptBody ?? throw new global::System.ArgumentNullException(nameof(promptBody));
            this.CommitMessage = commitMessage ?? throw new global::System.ArgumentNullException(nameof(commitMessage));
            this.Environment = environment;
            this.NewMajorVersion = newMajorVersion;
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrompt2025Request" /> class.
        /// </summary>
        public UpdatePrompt2025Request()
        {
        }
    }
}