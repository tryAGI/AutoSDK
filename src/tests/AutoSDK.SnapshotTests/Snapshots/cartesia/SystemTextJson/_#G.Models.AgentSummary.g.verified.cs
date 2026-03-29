//HintName: G.Models.AgentSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A summary of essential information about an agent.
    /// </summary>
    public sealed partial class AgentSummary
    {
        /// <summary>
        /// The ID of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique name of the agent, which can be used to identify the agent in the CLI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A brief description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The date and time when the agent was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the agent was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TtsVoice { get; set; }

        /// <summary>
        /// The language used for text-to-speech by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TtsLanguage { get; set; }

        /// <summary>
        /// The identifier for the webhook associated with the agent. Add or customize a webhook to your agent to receive events when calls are made to your agent via the Playground.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_id")]
        public string? WebhookId { get; set; }

        /// <summary>
        /// The date and time when the agent was deleted, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_repository")]
        public global::G.GitRepository? GitRepository { get; set; }

        /// <summary>
        /// The branch of the Git repository used for deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_deploy_branch")]
        public string? GitDeployBranch { get; set; }

        /// <summary>
        /// The phone numbers associated with the agent. Currently, you can only have one phone number per agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<global::G.PhoneNumberSummary>? PhoneNumbers { get; set; }

        /// <summary>
        /// Whether the agent has a text-to-agent run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_text_to_agent_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasTextToAgentRun { get; set; }

        /// <summary>
        /// The number of deployments associated with the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeploymentCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the agent.
        /// </param>
        /// <param name="name">
        /// The unique name of the agent, which can be used to identify the agent in the CLI.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the agent was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the agent was last updated.
        /// </param>
        /// <param name="ttsVoice">
        /// The ID of the voice.
        /// </param>
        /// <param name="ttsLanguage">
        /// The language used for text-to-speech by the agent.
        /// </param>
        /// <param name="hasTextToAgentRun">
        /// Whether the agent has a text-to-agent run.
        /// </param>
        /// <param name="deploymentCount">
        /// The number of deployments associated with the agent.
        /// </param>
        /// <param name="description">
        /// A brief description of the agent.
        /// </param>
        /// <param name="webhookId">
        /// The identifier for the webhook associated with the agent. Add or customize a webhook to your agent to receive events when calls are made to your agent via the Playground.
        /// </param>
        /// <param name="deletedAt">
        /// The date and time when the agent was deleted, if applicable.
        /// </param>
        /// <param name="gitRepository"></param>
        /// <param name="gitDeployBranch">
        /// The branch of the Git repository used for deployment.
        /// </param>
        /// <param name="phoneNumbers">
        /// The phone numbers associated with the agent. Currently, you can only have one phone number per agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSummary(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string ttsVoice,
            string ttsLanguage,
            bool hasTextToAgentRun,
            int deploymentCount,
            string? description,
            string? webhookId,
            global::System.DateTime? deletedAt,
            global::G.GitRepository? gitRepository,
            string? gitDeployBranch,
            global::System.Collections.Generic.IList<global::G.PhoneNumberSummary>? phoneNumbers)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TtsVoice = ttsVoice ?? throw new global::System.ArgumentNullException(nameof(ttsVoice));
            this.TtsLanguage = ttsLanguage ?? throw new global::System.ArgumentNullException(nameof(ttsLanguage));
            this.WebhookId = webhookId;
            this.DeletedAt = deletedAt;
            this.GitRepository = gitRepository;
            this.GitDeployBranch = gitDeployBranch;
            this.PhoneNumbers = phoneNumbers;
            this.HasTextToAgentRun = hasTextToAgentRun;
            this.DeploymentCount = deploymentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummary" /> class.
        /// </summary>
        public AgentSummary()
        {
        }
    }
}