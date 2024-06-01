//HintName: G.Models.AppPermissionsGitSshKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage git SSH keys.
    /// </summary>
    public enum AppPermissionsGitSshKeys
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
    public static class AppPermissionsGitSshKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsGitSshKeys value)
        {
            return value switch
            {
                AppPermissionsGitSshKeys.Read => "read",
                AppPermissionsGitSshKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsGitSshKeys ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsGitSshKeys.Read,
                "write" => AppPermissionsGitSshKeys.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}