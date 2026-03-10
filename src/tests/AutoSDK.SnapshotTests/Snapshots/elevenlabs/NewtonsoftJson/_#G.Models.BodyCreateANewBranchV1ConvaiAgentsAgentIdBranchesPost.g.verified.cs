//HintName: G.Models.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost
    {
        /// <summary>
        /// ID of the version to branch from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ParentVersionId { get; set; } = default!;

        /// <summary>
        /// Name of the branch. It is unique within the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description for the branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Changes to apply to conversation config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_config")]
        public object? ConversationConfig { get; set; }

        /// <summary>
        /// Changes to apply to platform settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform_settings")]
        public object? PlatformSettings { get; set; }

        /// <summary>
        /// Updated workflow definition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow")]
        public global::G.AgentWorkflowRequestModel? Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost" /> class.
        /// </summary>
        /// <param name="parentVersionId">
        /// ID of the version to branch from
        /// </param>
        /// <param name="name">
        /// Name of the branch. It is unique within the agent.
        /// </param>
        /// <param name="description">
        /// Description for the branch
        /// </param>
        /// <param name="conversationConfig">
        /// Changes to apply to conversation config
        /// </param>
        /// <param name="platformSettings">
        /// Changes to apply to platform settings
        /// </param>
        /// <param name="workflow">
        /// Updated workflow definition
        /// </param>
        public BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost(
            string parentVersionId,
            string name,
            string description,
            object? conversationConfig,
            object? platformSettings,
            global::G.AgentWorkflowRequestModel? workflow)
        {
            this.ParentVersionId = parentVersionId ?? throw new global::System.ArgumentNullException(nameof(parentVersionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ConversationConfig = conversationConfig;
            this.PlatformSettings = platformSettings;
            this.Workflow = workflow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost" /> class.
        /// </summary>
        public BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost()
        {
        }
    }
}