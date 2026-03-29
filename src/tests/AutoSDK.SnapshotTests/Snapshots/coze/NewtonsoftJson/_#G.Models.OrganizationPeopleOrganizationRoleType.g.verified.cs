//HintName: G.Models.OrganizationPeopleOrganizationRoleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationPeopleOrganizationRoleType
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
    public static class OrganizationPeopleOrganizationRoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationPeopleOrganizationRoleType value)
        {
            return value switch
            {
                OrganizationPeopleOrganizationRoleType.OrganizationAdmin => "organization_admin",
                OrganizationPeopleOrganizationRoleType.OrganizationGuest => "organization_guest",
                OrganizationPeopleOrganizationRoleType.OrganizationMember => "organization_member",
                OrganizationPeopleOrganizationRoleType.OrganizationSuperAdmin => "organization_super_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationPeopleOrganizationRoleType? ToEnum(string value)
        {
            return value switch
            {
                "organization_admin" => OrganizationPeopleOrganizationRoleType.OrganizationAdmin,
                "organization_guest" => OrganizationPeopleOrganizationRoleType.OrganizationGuest,
                "organization_member" => OrganizationPeopleOrganizationRoleType.OrganizationMember,
                "organization_super_admin" => OrganizationPeopleOrganizationRoleType.OrganizationSuperAdmin,
                _ => null,
            };
        }
    }
}