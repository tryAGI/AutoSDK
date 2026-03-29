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
        [global::Newtonsoft.Json.JsonProperty("promptBody", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIChatRequest PromptBody { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commitMessage", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitMessage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newMajorVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public bool NewMajorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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