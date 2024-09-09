//HintName: G.Models.AppPermissionsOrganizationCustomOrgRoles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for custom organization roles management.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationCustomOrgRoles
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
    public static class AppPermissionsOrganizationCustomOrgRolesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCustomOrgRoles value)
        {
            return value switch
            {
                AppPermissionsOrganizationCustomOrgRoles.Read => "read",
                AppPermissionsOrganizationCustomOrgRoles.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCustomOrgRoles? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationCustomOrgRoles.Read,
                "write" => AppPermissionsOrganizationCustomOrgRoles.Write,
                _ => null,
            };
        }
    }
}