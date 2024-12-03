//HintName: G.Models.AppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsPullRequests
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsPullRequests value)
        {
            return value switch
            {
                AppPermissionsPullRequests.Read => "read",
                AppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsPullRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsPullRequests.Read,
                "write" => AppPermissionsPullRequests.Write,
                _ => null,
            };
        }
    }
}