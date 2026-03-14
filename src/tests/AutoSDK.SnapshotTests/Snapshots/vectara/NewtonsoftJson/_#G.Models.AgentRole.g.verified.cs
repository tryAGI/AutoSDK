//HintName: G.Models.AgentRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent-specific role assignment.
    /// </summary>
    public sealed partial class AgentRole
    {
        /// <summary>
        /// The ID of the agent this role applies to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentKey { get; set; } = default!;

        /// <summary>
        /// The role assigned for this specific agent.<br/>
        /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
        /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
        /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
        /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentRoleRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRole" /> class.
        /// </summary>
        /// <param name="agentKey">
        /// The ID of the agent this role applies to.
        /// </param>
        /// <param name="role">
        /// The role assigned for this specific agent.<br/>
        /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
        /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
        /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
        /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.
        /// </param>
        public AgentRole(
            string agentKey,
            global::G.AgentRoleRole role)
        {
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRole" /> class.
        /// </summary>
        public AgentRole()
        {
        }
    }
}