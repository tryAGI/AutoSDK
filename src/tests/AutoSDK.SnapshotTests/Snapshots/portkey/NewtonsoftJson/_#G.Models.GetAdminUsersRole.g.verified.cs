//HintName: G.Models.GetAdminUsersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAdminUsersRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAdminUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminUsersRole value)
        {
            return value switch
            {
                GetAdminUsersRole.Admin => "admin",
                GetAdminUsersRole.Member => "member",
                GetAdminUsersRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetAdminUsersRole.Admin,
                "member" => GetAdminUsersRole.Member,
                "owner" => GetAdminUsersRole.Owner,
                _ => null,
            };
        }
    }
}