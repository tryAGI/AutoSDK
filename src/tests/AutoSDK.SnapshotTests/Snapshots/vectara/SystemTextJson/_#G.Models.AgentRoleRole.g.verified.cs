//HintName: G.Models.AgentRoleRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role assigned for this specific agent.<br/>
    /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
    /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
    /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
    /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.
    /// </summary>
    public enum AgentRoleRole
    {
        /// <summary>
        /// 
        /// </summary>
        AgentAdministrator,
        /// <summary>
        /// 
        /// </summary>
        AgentViewer,
        /// <summary>
        /// 
        /// </summary>
        AgentDeveloper,
        /// <summary>
        /// 
        /// </summary>
        AgentUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRoleRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRoleRole value)
        {
            return value switch
            {
                AgentRoleRole.AgentAdministrator => "agent_administrator",
                AgentRoleRole.AgentViewer => "agent_viewer",
                AgentRoleRole.AgentDeveloper => "agent_developer",
                AgentRoleRole.AgentUser => "agent_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRoleRole? ToEnum(string value)
        {
            return value switch
            {
                "agent_administrator" => AgentRoleRole.AgentAdministrator,
                "agent_viewer" => AgentRoleRole.AgentViewer,
                "agent_developer" => AgentRoleRole.AgentDeveloper,
                "agent_user" => AgentRoleRole.AgentUser,
                _ => null,
            };
        }
    }
}