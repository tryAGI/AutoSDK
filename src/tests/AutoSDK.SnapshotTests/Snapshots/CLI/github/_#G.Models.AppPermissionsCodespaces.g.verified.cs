//HintName: G.Models.AppPermissionsCodespaces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
    /// </summary>
    public enum AppPermissionsCodespaces
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
    public static class AppPermissionsCodespacesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsCodespaces value)
        {
            return value switch
            {
                AppPermissionsCodespaces.Read => "read",
                AppPermissionsCodespaces.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsCodespaces? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsCodespaces.Read,
                "write" => AppPermissionsCodespaces.Write,
                _ => null,
            };
        }
    }
}