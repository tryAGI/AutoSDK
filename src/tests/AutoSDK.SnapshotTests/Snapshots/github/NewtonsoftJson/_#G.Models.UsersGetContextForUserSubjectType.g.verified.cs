//HintName: G.Models.UsersGetContextForUserSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsersGetContextForUserSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue")]
        Issue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository")]
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