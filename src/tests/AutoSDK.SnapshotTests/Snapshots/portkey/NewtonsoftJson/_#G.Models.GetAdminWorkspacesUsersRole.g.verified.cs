//HintName: G.Models.GetAdminWorkspacesUsersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAdminWorkspacesUsersRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manager")]
        Manager,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAdminWorkspacesUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminWorkspacesUsersRole value)
        {
            return value switch
            {
                GetAdminWorkspacesUsersRole.Admin => "admin",
                GetAdminWorkspacesUsersRole.Manager => "manager",
                GetAdminWorkspacesUsersRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminWorkspacesUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetAdminWorkspacesUsersRole.Admin,
                "manager" => GetAdminWorkspacesUsersRole.Manager,
                "member" => GetAdminWorkspacesUsersRole.Member,
                _ => null,
            };
        }
    }
}