//HintName: G.Models.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2
    {
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2 value)
        {
            return value switch
            {
                BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2.WorkspaceAdmin => "workspace_admin",
                BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2.WorkspaceMember => "workspace_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2.WorkspaceAdmin,
                "workspace_member" => BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2.WorkspaceMember,
                _ => null,
            };
        }
    }
}