//HintName: G.Models.OrganizationRoleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationRoleType
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationAdmin,
        /// <summary>
        /// 
        /// </summary>
        OrganizationGuest,
        /// <summary>
        /// 
        /// </summary>
        OrganizationMember,
        /// <summary>
        /// 
        /// </summary>
        OrganizationSuperAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationRoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleType value)
        {
            return value switch
            {
                OrganizationRoleType.OrganizationAdmin => "organization_admin",
                OrganizationRoleType.OrganizationGuest => "organization_guest",
                OrganizationRoleType.OrganizationMember => "organization_member",
                OrganizationRoleType.OrganizationSuperAdmin => "organization_super_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleType? ToEnum(string value)
        {
            return value switch
            {
                "organization_admin" => OrganizationRoleType.OrganizationAdmin,
                "organization_guest" => OrganizationRoleType.OrganizationGuest,
                "organization_member" => OrganizationRoleType.OrganizationMember,
                "organization_super_admin" => OrganizationRoleType.OrganizationSuperAdmin,
                _ => null,
            };
        }
    }
}