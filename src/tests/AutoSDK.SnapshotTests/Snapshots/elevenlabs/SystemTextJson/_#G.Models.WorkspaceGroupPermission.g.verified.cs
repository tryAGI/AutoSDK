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
        AddVoiceFromVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        AiSpeechClassifier,
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
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        GroupMembersManage,
        /// <summary>
        /// 
        /// </summary>
        ImageVideoGeneration,
        /// <summary>
        /// 
        /// </summary>
        Music,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        PublishStudioProject,
        /// <summary>
        /// 
        /// </summary>
        PublishVoiceToVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountsManage,
        /// <summary>
        /// 
        /// </summary>
        ShareVoiceExternally,
        /// <summary>
        /// 
        /// </summary>
        SoundEffects,
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
        TermsOfServiceAccept,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        ViewFiatBalance,
        /// <summary>
        /// 
        /// </summary>
        VoiceIsolator,
        /// <summary>
        /// 
        /// </summary>
        VoiceLab,
        /// <summary>
        /// 
        /// </summary>
        VoiceoverStudio,
        /// <summary>
        /// 
        /// </summary>
        WebhooksManage,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAnalyticsFullRead,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMembersInvite,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMembersRemove,
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
                WorkspaceGroupPermission.AddVoiceFromVoiceLibrary => "add_voice_from_voice_library",
                WorkspaceGroupPermission.AiSpeechClassifier => "ai_speech_classifier",
                WorkspaceGroupPermission.AudioNative => "audio_native",
                WorkspaceGroupPermission.ConversationalAi => "conversational_ai",
                WorkspaceGroupPermission.CreateInstantVoiceClone => "create_instant_voice_clone",
                WorkspaceGroupPermission.CreateProfessionalVoiceClone => "create_professional_voice_clone",
                WorkspaceGroupPermission.CreateUserApiKey => "create_user_api_key",
                WorkspaceGroupPermission.Dubbing => "dubbing",
                WorkspaceGroupPermission.GroupMembersManage => "group_members_manage",
                WorkspaceGroupPermission.ImageVideoGeneration => "image_video_generation",
                WorkspaceGroupPermission.Music => "music",
                WorkspaceGroupPermission.Projects => "projects",
                WorkspaceGroupPermission.PublishStudioProject => "publish_studio_project",
                WorkspaceGroupPermission.PublishVoiceToVoiceLibrary => "publish_voice_to_voice_library",
                WorkspaceGroupPermission.ServiceAccountsManage => "service_accounts_manage",
                WorkspaceGroupPermission.ShareVoiceExternally => "share_voice_externally",
                WorkspaceGroupPermission.SoundEffects => "sound_effects",
                WorkspaceGroupPermission.SpeechToSpeech => "speech_to_speech",
                WorkspaceGroupPermission.SpeechToText => "speech_to_text",
                WorkspaceGroupPermission.TermsOfServiceAccept => "terms_of_service_accept",
                WorkspaceGroupPermission.TextToSpeech => "text_to_speech",
                WorkspaceGroupPermission.ViewFiatBalance => "view_fiat_balance",
                WorkspaceGroupPermission.VoiceIsolator => "voice_isolator",
                WorkspaceGroupPermission.VoiceLab => "voice_lab",
                WorkspaceGroupPermission.VoiceoverStudio => "voiceover_studio",
                WorkspaceGroupPermission.WebhooksManage => "webhooks_manage",
                WorkspaceGroupPermission.WorkspaceAnalyticsFullRead => "workspace_analytics_full_read",
                WorkspaceGroupPermission.WorkspaceMembersInvite => "workspace_members_invite",
                WorkspaceGroupPermission.WorkspaceMembersRemove => "workspace_members_remove",
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
                "add_voice_from_voice_library" => WorkspaceGroupPermission.AddVoiceFromVoiceLibrary,
                "ai_speech_classifier" => WorkspaceGroupPermission.AiSpeechClassifier,
                "audio_native" => WorkspaceGroupPermission.AudioNative,
                "conversational_ai" => WorkspaceGroupPermission.ConversationalAi,
                "create_instant_voice_clone" => WorkspaceGroupPermission.CreateInstantVoiceClone,
                "create_professional_voice_clone" => WorkspaceGroupPermission.CreateProfessionalVoiceClone,
                "create_user_api_key" => WorkspaceGroupPermission.CreateUserApiKey,
                "dubbing" => WorkspaceGroupPermission.Dubbing,
                "group_members_manage" => WorkspaceGroupPermission.GroupMembersManage,
                "image_video_generation" => WorkspaceGroupPermission.ImageVideoGeneration,
                "music" => WorkspaceGroupPermission.Music,
                "projects" => WorkspaceGroupPermission.Projects,
                "publish_studio_project" => WorkspaceGroupPermission.PublishStudioProject,
                "publish_voice_to_voice_library" => WorkspaceGroupPermission.PublishVoiceToVoiceLibrary,
                "service_accounts_manage" => WorkspaceGroupPermission.ServiceAccountsManage,
                "share_voice_externally" => WorkspaceGroupPermission.ShareVoiceExternally,
                "sound_effects" => WorkspaceGroupPermission.SoundEffects,
                "speech_to_speech" => WorkspaceGroupPermission.SpeechToSpeech,
                "speech_to_text" => WorkspaceGroupPermission.SpeechToText,
                "terms_of_service_accept" => WorkspaceGroupPermission.TermsOfServiceAccept,
                "text_to_speech" => WorkspaceGroupPermission.TextToSpeech,
                "view_fiat_balance" => WorkspaceGroupPermission.ViewFiatBalance,
                "voice_isolator" => WorkspaceGroupPermission.VoiceIsolator,
                "voice_lab" => WorkspaceGroupPermission.VoiceLab,
                "voiceover_studio" => WorkspaceGroupPermission.VoiceoverStudio,
                "webhooks_manage" => WorkspaceGroupPermission.WebhooksManage,
                "workspace_analytics_full_read" => WorkspaceGroupPermission.WorkspaceAnalyticsFullRead,
                "workspace_members_invite" => WorkspaceGroupPermission.WorkspaceMembersInvite,
                "workspace_members_remove" => WorkspaceGroupPermission.WorkspaceMembersRemove,
                _ => null,
            };
        }
    }
}