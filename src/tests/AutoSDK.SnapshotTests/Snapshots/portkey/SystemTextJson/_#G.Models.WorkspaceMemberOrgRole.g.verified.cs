//HintName: G.Models.WorkspaceMemberOrgRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: admin
    /// </summary>
    public enum WorkspaceMemberOrgRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
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