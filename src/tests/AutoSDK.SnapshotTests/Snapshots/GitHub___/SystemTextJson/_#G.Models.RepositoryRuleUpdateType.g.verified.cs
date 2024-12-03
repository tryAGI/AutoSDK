//HintName: G.Models.RepositoryRuleUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleUpdateType value)
        {
            return value switch
            {
                RepositoryRuleUpdateType.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "update" => RepositoryRuleUpdateType.Update,
                _ => null,
            };
        }
    }
}