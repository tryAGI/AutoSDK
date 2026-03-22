//HintName: G.Models.RepositoryRulesetSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the source of the ruleset
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetSourceType
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
    public static class RepositoryRulesetSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetSourceType value)
        {
            return value switch
            {
                RepositoryRulesetSourceType.Organization => "Organization",
                RepositoryRulesetSourceType.Repository => "Repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetSourceType? ToEnum(string value)
        {
            return value switch
            {
                "Organization" => RepositoryRulesetSourceType.Organization,
                "Repository" => RepositoryRulesetSourceType.Repository,
                _ => null,
            };
        }
    }
}