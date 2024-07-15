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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        Issue,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
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
                UsersGetContextForUserSubjectType.Organization => "organization",
                UsersGetContextForUserSubjectType.Repository => "repository",
                UsersGetContextForUserSubjectType.Issue => "issue",
                UsersGetContextForUserSubjectType.PullRequest => "pull_request",
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
                "organization" => UsersGetContextForUserSubjectType.Organization,
                "repository" => UsersGetContextForUserSubjectType.Repository,
                "issue" => UsersGetContextForUserSubjectType.Issue,
                "pull_request" => UsersGetContextForUserSubjectType.PullRequest,
                _ => null,
            };
        }
    }
}