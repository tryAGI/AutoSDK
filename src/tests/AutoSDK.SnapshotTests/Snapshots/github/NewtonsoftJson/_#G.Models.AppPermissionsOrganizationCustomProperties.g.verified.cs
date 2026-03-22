//HintName: G.Models.AppPermissionsOrganizationCustomProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for custom property management.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationCustomProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
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
    public static class AppPermissionsOrganizationCustomPropertiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCustomProperties value)
        {
            return value switch
            {
                AppPermissionsOrganizationCustomProperties.Admin => "admin",
                AppPermissionsOrganizationCustomProperties.Read => "read",
                AppPermissionsOrganizationCustomProperties.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCustomProperties? ToEnum(string value)
        {
            return value switch
            {
                "admin" => AppPermissionsOrganizationCustomProperties.Admin,
                "read" => AppPermissionsOrganizationCustomProperties.Read,
                "write" => AppPermissionsOrganizationCustomProperties.Write,
                _ => null,
            };
        }
    }
}