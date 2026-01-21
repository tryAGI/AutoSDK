//HintName: G.Models.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2
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