//HintName: G.Models.GetAdminUsersInvitesRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAdminUsersInvitesRole
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAdminUsersInvitesRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminUsersInvitesRole value)
        {
            return value switch
            {
                GetAdminUsersInvitesRole.Admin => "admin",
                GetAdminUsersInvitesRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminUsersInvitesRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetAdminUsersInvitesRole.Admin,
                "member" => GetAdminUsersInvitesRole.Member,
                _ => null,
            };
        }
    }
}