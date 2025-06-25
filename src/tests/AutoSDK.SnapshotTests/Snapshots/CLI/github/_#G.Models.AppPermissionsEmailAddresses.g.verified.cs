//HintName: G.Models.AppPermissionsEmailAddresses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the email addresses belonging to a user.
    /// </summary>
    public enum AppPermissionsEmailAddresses
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
    public static class AppPermissionsEmailAddressesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsEmailAddresses value)
        {
            return value switch
            {
                AppPermissionsEmailAddresses.Read => "read",
                AppPermissionsEmailAddresses.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsEmailAddresses? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsEmailAddresses.Read,
                "write" => AppPermissionsEmailAddresses.Write,
                _ => null,
            };
        }
    }
}