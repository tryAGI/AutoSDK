//HintName: G.Models.AppPermissionsStatuses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for commit statuses.
    /// </summary>
    public enum AppPermissionsStatuses
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
    public static class AppPermissionsStatusesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsStatuses value)
        {
            return value switch
            {
                AppPermissionsStatuses.Read => "read",
                AppPermissionsStatuses.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsStatuses? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsStatuses.Read,
                "write" => AppPermissionsStatuses.Write,
                _ => null,
            };
        }
    }
}