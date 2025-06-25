//HintName: G.Models.AppPermissionsProfile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the profile settings belonging to a user.
    /// </summary>
    public enum AppPermissionsProfile
    {
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsProfile value)
        {
            return value switch
            {
                AppPermissionsProfile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsProfile? ToEnum(string value)
        {
            return value switch
            {
                "write" => AppPermissionsProfile.Write,
                _ => null,
            };
        }
    }
}