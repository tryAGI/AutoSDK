//HintName: G.Models.AppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for checks on code.
    /// </summary>
    public enum AppPermissionsChecks
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
    public static class AppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsChecks value)
        {
            return value switch
            {
                AppPermissionsChecks.Read => "read",
                AppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsChecks ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsChecks.Read,
                "write" => AppPermissionsChecks.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}