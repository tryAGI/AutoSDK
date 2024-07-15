//HintName: G.Models.RepositoryRuleCommitMessagePatternType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleCommitMessagePatternType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_message_pattern")]
        CommitMessagePattern,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCommitMessagePatternTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitMessagePatternType value)
        {
            return value switch
            {
                RepositoryRuleCommitMessagePatternType.CommitMessagePattern => "commit_message_pattern",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitMessagePatternType? ToEnum(string value)
        {
            return value switch
            {
                "commit_message_pattern" => RepositoryRuleCommitMessagePatternType.CommitMessagePattern,
                _ => null,
            };
        }
    }
}