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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// The role assigned for this specific agent.<br/>
        /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
        /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
        /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
        /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRoleRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentRoleRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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