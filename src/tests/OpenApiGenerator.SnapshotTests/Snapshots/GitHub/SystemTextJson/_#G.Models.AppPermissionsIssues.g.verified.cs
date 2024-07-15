//HintName: G.Models.AppPermissionsIssues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
    /// </summary>
    public enum AppPermissionsIssues
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsIssuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsIssues value)
        {
            return value switch
            {
                AppPermissionsIssues.Read => "read",
                AppPermissionsIssues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsIssues? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsIssues.Read,
                "write" => AppPermissionsIssues.Write,
                _ => null,
            };
        }
    }
}