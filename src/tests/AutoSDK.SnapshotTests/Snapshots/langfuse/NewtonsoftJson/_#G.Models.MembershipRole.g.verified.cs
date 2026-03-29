//HintName: G.Models.MembershipRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ADMIN")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEWER")]
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MembershipRole value)
        {
            return value switch
            {
                MembershipRole.Admin => "ADMIN",
                MembershipRole.Member => "MEMBER",
                MembershipRole.Owner => "OWNER",
                MembershipRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => MembershipRole.Admin,
                "MEMBER" => MembershipRole.Member,
                "OWNER" => MembershipRole.Owner,
                "VIEWER" => MembershipRole.Viewer,
                _ => null,
            };
        }
    }
}