//HintName: G.Models.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization_admin")]
        OrganizationAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization_guest")]
        OrganizationGuest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization_member")]
        OrganizationMember,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization_super_admin")]
        OrganizationSuperAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType value)
        {
            return value switch
            {
                OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationAdmin => "organization_admin",
                OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationGuest => "organization_guest",
                OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationMember => "organization_member",
                OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationSuperAdmin => "organization_super_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType? ToEnum(string value)
        {
            return value switch
            {
                "organization_admin" => OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationAdmin,
                "organization_guest" => OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationGuest,
                "organization_member" => OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationMember,
                "organization_super_admin" => OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType.OrganizationSuperAdmin,
                _ => null,
            };
        }
    }
}