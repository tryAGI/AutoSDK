//HintName: G.Models.PropertiesUsersItemsRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PropertiesUsersItemsRole
    {
        /// <summary>
        /// 
        /// </summary>
        EnterpriseAdmin,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesUsersItemsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesUsersItemsRole value)
        {
            return value switch
            {
                PropertiesUsersItemsRole.EnterpriseAdmin => "enterprise_admin",
                PropertiesUsersItemsRole.EnterpriseMember => "enterprise_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesUsersItemsRole? ToEnum(string value)
        {
            return value switch
            {
                "enterprise_admin" => PropertiesUsersItemsRole.EnterpriseAdmin,
                "enterprise_member" => PropertiesUsersItemsRole.EnterpriseMember,
                _ => null,
            };
        }
    }
}