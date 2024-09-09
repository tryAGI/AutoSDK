//HintName: G.Models.AppPermissionsInteractionLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage interaction limits on a repository.
    /// </summary>
    public enum AppPermissionsInteractionLimits
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
    public static class AppPermissionsInteractionLimitsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsInteractionLimits value)
        {
            return value switch
            {
                AppPermissionsInteractionLimits.Read => "read",
                AppPermissionsInteractionLimits.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsInteractionLimits? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsInteractionLimits.Read,
                "write" => AppPermissionsInteractionLimits.Write,
                _ => null,
            };
        }
    }
}