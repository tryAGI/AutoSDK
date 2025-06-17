//HintName: G.Models.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The workspace permission of the user<br/>
    /// Example: workspace_member
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external")]
        External,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="support_l1")]
        SupportL1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="support_l2")]
        SupportL2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderator")]
        Moderator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sales")]
        Sales,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_mixer")]
        VoiceMixer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_admin")]
        VoiceAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_admin")]
        ConvaiAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise_viewer")]
        EnterpriseViewer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="quality_check_admin")]
        QualityCheckAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_migration_admin")]
        WorkspaceMigrationAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="human_reviewer")]
        HumanReviewer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="productions_admin")]
        ProductionsAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission value)
        {
            return value switch
            {
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.External => "external",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.Admin => "admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.WorkspaceAdmin => "workspace_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.WorkspaceMember => "workspace_member",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.SupportL1 => "support_l1",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.SupportL2 => "support_l2",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.Moderator => "moderator",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.Sales => "sales",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.VoiceMixer => "voice_mixer",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.VoiceAdmin => "voice_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.ConvaiAdmin => "convai_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.EnterpriseViewer => "enterprise_viewer",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.QualityCheckAdmin => "quality_check_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.WorkspaceMigrationAdmin => "workspace_migration_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.HumanReviewer => "human_reviewer",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.ProductionsAdmin => "productions_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission? ToEnum(string value)
        {
            return value switch
            {
                "external" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.External,
                "admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.Admin,
                "workspace_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.WorkspaceAdmin,
                "workspace_member" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.WorkspaceMember,
                "support_l1" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.SupportL1,
                "support_l2" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.SupportL2,
                "moderator" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.Moderator,
                "sales" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.Sales,
                "voice_mixer" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.VoiceMixer,
                "voice_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.VoiceAdmin,
                "convai_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.ConvaiAdmin,
                "enterprise_viewer" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.EnterpriseViewer,
                "quality_check_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.QualityCheckAdmin,
                "workspace_migration_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.WorkspaceMigrationAdmin,
                "human_reviewer" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.HumanReviewer,
                "productions_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission.ProductionsAdmin,
                _ => null,
            };
        }
    }
}