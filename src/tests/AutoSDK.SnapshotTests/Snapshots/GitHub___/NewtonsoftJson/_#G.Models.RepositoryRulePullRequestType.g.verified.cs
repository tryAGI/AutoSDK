//HintName: G.Models.RepositoryRulePullRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulePullRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulePullRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulePullRequestType value)
        {
            return value switch
            {
                RepositoryRulePullRequestType.PullRequest => "pull_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulePullRequestType? ToEnum(string value)
        {
            return value switch
            {
                "pull_request" => RepositoryRulePullRequestType.PullRequest,
                _ => null,
            };
        }
    }
}