//HintName: G.Models.AppPermissionsGpgKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsGpgKeys
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsGpgKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsGpgKeys value)
        {
            return value switch
            {
                AppPermissionsGpgKeys.Read => "read",
                AppPermissionsGpgKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsGpgKeys ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsGpgKeys.Read,
                "write" => AppPermissionsGpgKeys.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}