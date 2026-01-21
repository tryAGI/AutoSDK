//HintName: G.Models.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMember,
        /// <summary>
        /// 
        /// </summary>
        SupportL1,
        /// <summary>
        /// 
        /// </summary>
        SupportL2,
        /// <summary>
        /// 
        /// </summary>
        Moderator,
        /// <summary>
        /// 
        /// </summary>
        Sales,
        /// <summary>
        /// 
        /// </summary>
        VoiceMixer,
        /// <summary>
        /// 
        /// </summary>
        VoiceAdmin,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAdmin,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseViewer,
        /// <summary>
        /// 
        /// </summary>
        QualityCheckAdmin,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMigrationAdmin,
        /// <summary>
        /// 
        /// </summary>
        HumanReviewer,
        /// <summary>
        /// 
        /// </summary>
        ProductionsAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2 value)
        {
            return value switch
            {
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.External => "external",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.Admin => "admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.WorkspaceAdmin => "workspace_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.WorkspaceMember => "workspace_member",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.SupportL1 => "support_l1",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.SupportL2 => "support_l2",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.Moderator => "moderator",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.Sales => "sales",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.VoiceMixer => "voice_mixer",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.VoiceAdmin => "voice_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.ConvaiAdmin => "convai_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.EnterpriseViewer => "enterprise_viewer",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.QualityCheckAdmin => "quality_check_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.WorkspaceMigrationAdmin => "workspace_migration_admin",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.HumanReviewer => "human_reviewer",
                BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.ProductionsAdmin => "productions_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2? ToEnum(string value)
        {
            return value switch
            {
                "external" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.External,
                "admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.Admin,
                "workspace_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.WorkspaceAdmin,
                "workspace_member" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.WorkspaceMember,
                "support_l1" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.SupportL1,
                "support_l2" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.SupportL2,
                "moderator" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.Moderator,
                "sales" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.Sales,
                "voice_mixer" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.VoiceMixer,
                "voice_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.VoiceAdmin,
                "convai_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.ConvaiAdmin,
                "enterprise_viewer" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.EnterpriseViewer,
                "quality_check_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.QualityCheckAdmin,
                "workspace_migration_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.WorkspaceMigrationAdmin,
                "human_reviewer" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.HumanReviewer,
                "productions_admin" => BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.ProductionsAdmin,
                _ => null,
            };
        }
    }
}