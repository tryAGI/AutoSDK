//HintName: G.Models.RepositoryRulesetBypassActorActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of actor that can bypass a ruleset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetBypassActorActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DeployKey")]
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Integration")]
        Integration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OrganizationAdmin")]
        OrganizationAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RepositoryRole")]
        RepositoryRole,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Team")]
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetBypassActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetBypassActorActorType value)
        {
            return value switch
            {
                RepositoryRulesetBypassActorActorType.DeployKey => "DeployKey",
                RepositoryRulesetBypassActorActorType.Integration => "Integration",
                RepositoryRulesetBypassActorActorType.OrganizationAdmin => "OrganizationAdmin",
                RepositoryRulesetBypassActorActorType.RepositoryRole => "RepositoryRole",
                RepositoryRulesetBypassActorActorType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetBypassActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "DeployKey" => RepositoryRulesetBypassActorActorType.DeployKey,
                "Integration" => RepositoryRulesetBypassActorActorType.Integration,
                "OrganizationAdmin" => RepositoryRulesetBypassActorActorType.OrganizationAdmin,
                "RepositoryRole" => RepositoryRulesetBypassActorActorType.RepositoryRole,
                "Team" => RepositoryRulesetBypassActorActorType.Team,
                _ => null,
            };
        }
    }
}