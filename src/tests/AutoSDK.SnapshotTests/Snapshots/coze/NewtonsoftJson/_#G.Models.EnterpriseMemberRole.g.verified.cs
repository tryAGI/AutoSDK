//HintName: G.Models.EnterpriseMemberRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnterpriseMemberRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise_admin")]
        EnterpriseAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise_member")]
        EnterpriseMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterpriseMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseMemberRole value)
        {
            return value switch
            {
                EnterpriseMemberRole.EnterpriseAdmin => "enterprise_admin",
                EnterpriseMemberRole.EnterpriseMember => "enterprise_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "enterprise_admin" => EnterpriseMemberRole.EnterpriseAdmin,
                "enterprise_member" => EnterpriseMemberRole.EnterpriseMember,
                _ => null,
            };
        }
    }
}