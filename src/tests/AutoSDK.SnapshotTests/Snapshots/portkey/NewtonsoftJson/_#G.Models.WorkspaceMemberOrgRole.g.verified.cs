//HintName: G.Models.WorkspaceMemberOrgRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: admin
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkspaceMemberOrgRole
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
    public static class WorkspaceMemberOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceMemberOrgRole value)
        {
            return value switch
            {
                WorkspaceMemberOrgRole.Admin => "admin",
                WorkspaceMemberOrgRole.Member => "member",
                WorkspaceMemberOrgRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceMemberOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WorkspaceMemberOrgRole.Admin,
                "member" => WorkspaceMemberOrgRole.Member,
                "owner" => WorkspaceMemberOrgRole.Owner,
                _ => null,
            };
        }
    }
}