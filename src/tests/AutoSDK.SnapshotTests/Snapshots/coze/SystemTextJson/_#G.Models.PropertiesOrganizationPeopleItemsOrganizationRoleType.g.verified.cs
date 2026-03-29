//HintName: G.Models.PropertiesOrganizationPeopleItemsOrganizationRoleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PropertiesOrganizationPeopleItemsOrganizationRoleType
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
    public static class PropertiesOrganizationPeopleItemsOrganizationRoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesOrganizationPeopleItemsOrganizationRoleType value)
        {
            return value switch
            {
                PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationAdmin => "organization_admin",
                PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationGuest => "organization_guest",
                PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationMember => "organization_member",
                PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationSuperAdmin => "organization_super_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesOrganizationPeopleItemsOrganizationRoleType? ToEnum(string value)
        {
            return value switch
            {
                "organization_admin" => PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationAdmin,
                "organization_guest" => PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationGuest,
                "organization_member" => PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationMember,
                "organization_super_admin" => PropertiesOrganizationPeopleItemsOrganizationRoleType.OrganizationSuperAdmin,
                _ => null,
            };
        }
    }
}