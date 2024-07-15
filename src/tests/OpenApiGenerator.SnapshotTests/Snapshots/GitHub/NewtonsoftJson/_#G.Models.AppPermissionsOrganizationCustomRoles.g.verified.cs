//HintName: G.Models.AppPermissionsOrganizationCustomRoles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for custom repository roles management.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationCustomRoles
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
    public static class AppPermissionsOrganizationCustomRolesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCustomRoles value)
        {
            return value switch
            {
                AppPermissionsOrganizationCustomRoles.Read => "read",
                AppPermissionsOrganizationCustomRoles.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCustomRoles? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationCustomRoles.Read,
                "write" => AppPermissionsOrganizationCustomRoles.Write,
                _ => null,
            };
        }
    }
}