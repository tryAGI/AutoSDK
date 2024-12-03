//HintName: G.Models.RepositoryRuleCommitAuthorEmailPatternType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleCommitAuthorEmailPatternType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_author_email_pattern")]
        CommitAuthorEmailPattern,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCommitAuthorEmailPatternTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitAuthorEmailPatternType value)
        {
            return value switch
            {
                RepositoryRuleCommitAuthorEmailPatternType.CommitAuthorEmailPattern => "commit_author_email_pattern",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitAuthorEmailPatternType? ToEnum(string value)
        {
            return value switch
            {
                "commit_author_email_pattern" => RepositoryRuleCommitAuthorEmailPatternType.CommitAuthorEmailPattern,
                _ => null,
            };
        }
    }
}