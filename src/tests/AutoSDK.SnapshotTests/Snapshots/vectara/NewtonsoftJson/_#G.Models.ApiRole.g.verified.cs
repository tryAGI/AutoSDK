//HintName: G.Models.ApiRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Roles that a user or an app client can take on.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="administrator")]
        Administrator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="billing_administrator")]
        BillingAdministrator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="corpus_administrator")]
        CorpusAdministrator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="corpus_developer")]
        CorpusDeveloper,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_administrator")]
        AgentAdministrator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_viewer")]
        AgentViewer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_developer")]
        AgentDeveloper,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_user")]
        AgentUser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline_administrator")]
        PipelineAdministrator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline_viewer")]
        PipelineViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiRole value)
        {
            return value switch
            {
                ApiRole.Owner => "owner",
                ApiRole.Administrator => "administrator",
                ApiRole.BillingAdministrator => "billing_administrator",
                ApiRole.CorpusAdministrator => "corpus_administrator",
                ApiRole.CorpusDeveloper => "corpus_developer",
                ApiRole.AgentAdministrator => "agent_administrator",
                ApiRole.AgentViewer => "agent_viewer",
                ApiRole.AgentDeveloper => "agent_developer",
                ApiRole.AgentUser => "agent_user",
                ApiRole.PipelineAdministrator => "pipeline_administrator",
                ApiRole.PipelineViewer => "pipeline_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => ApiRole.Owner,
                "administrator" => ApiRole.Administrator,
                "billing_administrator" => ApiRole.BillingAdministrator,
                "corpus_administrator" => ApiRole.CorpusAdministrator,
                "corpus_developer" => ApiRole.CorpusDeveloper,
                "agent_administrator" => ApiRole.AgentAdministrator,
                "agent_viewer" => ApiRole.AgentViewer,
                "agent_developer" => ApiRole.AgentDeveloper,
                "agent_user" => ApiRole.AgentUser,
                "pipeline_administrator" => ApiRole.PipelineAdministrator,
                "pipeline_viewer" => ApiRole.PipelineViewer,
                _ => null,
            };
        }
    }
}