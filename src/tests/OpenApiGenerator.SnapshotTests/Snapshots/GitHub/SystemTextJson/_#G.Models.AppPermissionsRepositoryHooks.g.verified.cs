//HintName: G.Models.AppPermissionsRepositoryHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
    /// </summary>
    public enum AppPermissionsRepositoryHooks
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
    public static class AppPermissionsRepositoryHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsRepositoryHooks value)
        {
            return value switch
            {
                AppPermissionsRepositoryHooks.Read => "read",
                AppPermissionsRepositoryHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsRepositoryHooks ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsRepositoryHooks.Read,
                "write" => AppPermissionsRepositoryHooks.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}