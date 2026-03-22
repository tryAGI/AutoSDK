//HintName: G.Models.UsersGetContextForUserSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetContextForUserSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Issue,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetContextForUserSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetContextForUserSubjectType value)
        {
            return value switch
            {
                UsersGetContextForUserSubjectType.Issue => "issue",
                UsersGetContextForUserSubjectType.Organization => "organization",
                UsersGetContextForUserSubjectType.PullRequest => "pull_request",
                UsersGetContextForUserSubjectType.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetContextForUserSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "issue" => UsersGetContextForUserSubjectType.Issue,
                "organization" => UsersGetContextForUserSubjectType.Organization,
                "pull_request" => UsersGetContextForUserSubjectType.PullRequest,
                "repository" => UsersGetContextForUserSubjectType.Repository,
                _ => null,
            };
        }
    }
}