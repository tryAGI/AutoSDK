//HintName: G.Models.PostAgentAvatarResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAgentAvatarResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAgentAvatarResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="avatarUrl"></param>
        public PostAgentAvatarResponseModel(
            string agentId,
            string? avatarUrl)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AvatarUrl = avatarUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAgentAvatarResponseModel" /> class.
        /// </summary>
        public PostAgentAvatarResponseModel()
        {
        }
    }
}