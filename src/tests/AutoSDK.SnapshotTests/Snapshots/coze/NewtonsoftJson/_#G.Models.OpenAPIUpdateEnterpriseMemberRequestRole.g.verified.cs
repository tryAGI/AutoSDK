//HintName: G.Models.OpenAPIUpdateEnterpriseMemberRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIUpdateEnterpriseMemberRequestRole
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
    public static class OpenAPIUpdateEnterpriseMemberRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIUpdateEnterpriseMemberRequestRole value)
        {
            return value switch
            {
                OpenAPIUpdateEnterpriseMemberRequestRole.EnterpriseAdmin => "enterprise_admin",
                OpenAPIUpdateEnterpriseMemberRequestRole.EnterpriseMember => "enterprise_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIUpdateEnterpriseMemberRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "enterprise_admin" => OpenAPIUpdateEnterpriseMemberRequestRole.EnterpriseAdmin,
                "enterprise_member" => OpenAPIUpdateEnterpriseMemberRequestRole.EnterpriseMember,
                _ => null,
            };
        }
    }
}