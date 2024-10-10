//HintName: G.Models.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role dictating permissions in the workspace.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_admin")]
        WorkspaceAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_member")]
        WorkspaceMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole value)
        {
            return value switch
            {
                BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole.WorkspaceAdmin => "workspace_admin",
                BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole.WorkspaceMember => "workspace_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole.WorkspaceAdmin,
                "workspace_member" => BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole.WorkspaceMember,
                _ => null,
            };
        }
    }
}