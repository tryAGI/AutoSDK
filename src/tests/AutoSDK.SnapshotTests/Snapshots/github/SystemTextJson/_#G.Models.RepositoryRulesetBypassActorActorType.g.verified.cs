//HintName: G.Models.RepositoryRulesetBypassActorActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of actor that can bypass a ruleset.
    /// </summary>
    public enum RepositoryRulesetBypassActorActorType
    {
        /// <summary>
        /// 
        /// </summary>
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        OrganizationAdmin,
        /// <summary>
        /// 
        /// </summary>
        RepositoryRole,
        /// <summary>
        /// 
        /// </summary>
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