//HintName: G.Models.AppPermissionsTeamDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage team discussions and related comments.
    /// </summary>
    public enum AppPermissionsTeamDiscussions
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
    public static class AppPermissionsTeamDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsTeamDiscussions value)
        {
            return value switch
            {
                AppPermissionsTeamDiscussions.Read => "read",
                AppPermissionsTeamDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsTeamDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsTeamDiscussions.Read,
                "write" => AppPermissionsTeamDiscussions.Write,
                _ => null,
            };
        }
    }
}