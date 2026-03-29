//HintName: G.Models.WorkspaceInviteRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceInviteRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Manager,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceInviteRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceInviteRole value)
        {
            return value switch
            {
                WorkspaceInviteRole.Admin => "admin",
                WorkspaceInviteRole.Manager => "manager",
                WorkspaceInviteRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceInviteRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WorkspaceInviteRole.Admin,
                "manager" => WorkspaceInviteRole.Manager,
                "member" => WorkspaceInviteRole.Member,
                _ => null,
            };
        }
    }
}