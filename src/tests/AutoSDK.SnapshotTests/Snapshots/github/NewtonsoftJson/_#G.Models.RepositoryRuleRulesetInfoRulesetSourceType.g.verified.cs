//HintName: G.Models.RepositoryRuleRulesetInfoRulesetSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of source for the ruleset that includes this rule.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleRulesetInfoRulesetSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Repository")]
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleRulesetInfoRulesetSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleRulesetInfoRulesetSourceType value)
        {
            return value switch
            {
                RepositoryRuleRulesetInfoRulesetSourceType.Organization => "Organization",
                RepositoryRuleRulesetInfoRulesetSourceType.Repository => "Repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleRulesetInfoRulesetSourceType? ToEnum(string value)
        {
            return value switch
            {
                "Organization" => RepositoryRuleRulesetInfoRulesetSourceType.Organization,
                "Repository" => RepositoryRuleRulesetInfoRulesetSourceType.Repository,
                _ => null,
            };
        }
    }
}