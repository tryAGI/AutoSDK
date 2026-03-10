//HintName: G.Models.WorkspaceGroupPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceGroupPermission
    {
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        SpeechToText,
        /// <summary>
        /// 
        /// </summary>
        VoiceLab,
        /// <summary>
        /// 
        /// </summary>
        SoundEffects,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        VoiceoverStudio,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        AudioNative,
        /// <summary>
        /// 
        /// </summary>
        ConversationalAi,
        /// <summary>
        /// 
        /// </summary>
        VoiceIsolator,
        /// <summary>
        /// 
        /// </summary>
        AiSpeechClassifier,
        /// <summary>
        /// 
        /// </summary>
        AddVoiceFromVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        CreateInstantVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        CreateProfessionalVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        CreateUserApiKey,
        /// <summary>
        /// 
        /// </summary>
        PublishStudioProject,
        /// <summary>
        /// 
        /// </summary>
        Music,
        /// <summary>
        /// 
        /// </summary>
        ImageVideoGeneration,
        /// <summary>
        /// 
        /// </summary>
        ShareVoiceExternally,
        /// <summary>
        /// 
        /// </summary>
        PublishVoiceToVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        ViewFiatBalance,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAnalyticsFullRead,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountsManage,
        /// <summary>
        /// 
        /// </summary>
        WebhooksManage,
        /// <summary>
        /// 
        /// </summary>
        GroupMembersManage,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMembersInvite,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMembersRemove,
        /// <summary>
        /// 
        /// </summary>
        TermsOfServiceAccept,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceGroupPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceGroupPermission value)
        {
            return value switch
            {
                WorkspaceGroupPermission.TextToSpeech => "text_to_speech",
                WorkspaceGroupPermission.SpeechToSpeech => "speech_to_speech",
                WorkspaceGroupPermission.SpeechToText => "speech_to_text",
                WorkspaceGroupPermission.VoiceLab => "voice_lab",
                WorkspaceGroupPermission.SoundEffects => "sound_effects",
                WorkspaceGroupPermission.Projects => "projects",
                WorkspaceGroupPermission.VoiceoverStudio => "voiceover_studio",
                WorkspaceGroupPermission.Dubbing => "dubbing",
                WorkspaceGroupPermission.AudioNative => "audio_native",
                WorkspaceGroupPermission.ConversationalAi => "conversational_ai",
                WorkspaceGroupPermission.VoiceIsolator => "voice_isolator",
                WorkspaceGroupPermission.AiSpeechClassifier => "ai_speech_classifier",
                WorkspaceGroupPermission.AddVoiceFromVoiceLibrary => "add_voice_from_voice_library",
                WorkspaceGroupPermission.CreateInstantVoiceClone => "create_instant_voice_clone",
                WorkspaceGroupPermission.CreateProfessionalVoiceClone => "create_professional_voice_clone",
                WorkspaceGroupPermission.CreateUserApiKey => "create_user_api_key",
                WorkspaceGroupPermission.PublishStudioProject => "publish_studio_project",
                WorkspaceGroupPermission.Music => "music",
                WorkspaceGroupPermission.ImageVideoGeneration => "image_video_generation",
                WorkspaceGroupPermission.ShareVoiceExternally => "share_voice_externally",
                WorkspaceGroupPermission.PublishVoiceToVoiceLibrary => "publish_voice_to_voice_library",
                WorkspaceGroupPermission.ViewFiatBalance => "view_fiat_balance",
                WorkspaceGroupPermission.WorkspaceAnalyticsFullRead => "workspace_analytics_full_read",
                WorkspaceGroupPermission.ServiceAccountsManage => "service_accounts_manage",
                WorkspaceGroupPermission.WebhooksManage => "webhooks_manage",
                WorkspaceGroupPermission.GroupMembersManage => "group_members_manage",
                WorkspaceGroupPermission.WorkspaceMembersInvite => "workspace_members_invite",
                WorkspaceGroupPermission.WorkspaceMembersRemove => "workspace_members_remove",
                WorkspaceGroupPermission.TermsOfServiceAccept => "terms_of_service_accept",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceGroupPermission? ToEnum(string value)
        {
            return value switch
            {
                "text_to_speech" => WorkspaceGroupPermission.TextToSpeech,
                "speech_to_speech" => WorkspaceGroupPermission.SpeechToSpeech,
                "speech_to_text" => WorkspaceGroupPermission.SpeechToText,
                "voice_lab" => WorkspaceGroupPermission.VoiceLab,
                "sound_effects" => WorkspaceGroupPermission.SoundEffects,
                "projects" => WorkspaceGroupPermission.Projects,
                "voiceover_studio" => WorkspaceGroupPermission.VoiceoverStudio,
                "dubbing" => WorkspaceGroupPermission.Dubbing,
                "audio_native" => WorkspaceGroupPermission.AudioNative,
                "conversational_ai" => WorkspaceGroupPermission.ConversationalAi,
                "voice_isolator" => WorkspaceGroupPermission.VoiceIsolator,
                "ai_speech_classifier" => WorkspaceGroupPermission.AiSpeechClassifier,
                "add_voice_from_voice_library" => WorkspaceGroupPermission.AddVoiceFromVoiceLibrary,
                "create_instant_voice_clone" => WorkspaceGroupPermission.CreateInstantVoiceClone,
                "create_professional_voice_clone" => WorkspaceGroupPermission.CreateProfessionalVoiceClone,
                "create_user_api_key" => WorkspaceGroupPermission.CreateUserApiKey,
                "publish_studio_project" => WorkspaceGroupPermission.PublishStudioProject,
                "music" => WorkspaceGroupPermission.Music,
                "image_video_generation" => WorkspaceGroupPermission.ImageVideoGeneration,
                "share_voice_externally" => WorkspaceGroupPermission.ShareVoiceExternally,
                "publish_voice_to_voice_library" => WorkspaceGroupPermission.PublishVoiceToVoiceLibrary,
                "view_fiat_balance" => WorkspaceGroupPermission.ViewFiatBalance,
                "workspace_analytics_full_read" => WorkspaceGroupPermission.WorkspaceAnalyticsFullRead,
                "service_accounts_manage" => WorkspaceGroupPermission.ServiceAccountsManage,
                "webhooks_manage" => WorkspaceGroupPermission.WebhooksManage,
                "group_members_manage" => WorkspaceGroupPermission.GroupMembersManage,
                "workspace_members_invite" => WorkspaceGroupPermission.WorkspaceMembersInvite,
                "workspace_members_remove" => WorkspaceGroupPermission.WorkspaceMembersRemove,
                "terms_of_service_accept" => WorkspaceGroupPermission.TermsOfServiceAccept,
                _ => null,
            };
        }
    }
}