//HintName: G.Models.RepositoryRuleTagNamePatternType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleTagNamePatternType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag_name_pattern")]
        TagNamePattern,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleTagNamePatternTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleTagNamePatternType value)
        {
            return value switch
            {
                RepositoryRuleTagNamePatternType.TagNamePattern => "tag_name_pattern",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleTagNamePatternType ToEnum(string value)
        {
            return value switch
            {
                "tag_name_pattern" => RepositoryRuleTagNamePatternType.TagNamePattern,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}