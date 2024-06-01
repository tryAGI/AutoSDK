//HintName: G.Models.AppPermissionsActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
    /// </summary>
    public enum AppPermissionsActions
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
    public static class AppPermissionsActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsActions value)
        {
            return value switch
            {
                AppPermissionsActions.Read => "read",
                AppPermissionsActions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsActions ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsActions.Read,
                "write" => AppPermissionsActions.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}