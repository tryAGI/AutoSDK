//HintName: G.Models.PermissionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PermissionType
    {
        /// <summary>
        /// 
        /// </summary>
        AddVoiceFromVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        AudioNativeRead,
        /// <summary>
        /// 
        /// </summary>
        AudioNativeWrite,
        /// <summary>
        /// 
        /// </summary>
        ConvaiRead,
        /// <summary>
        /// 
        /// </summary>
        ConvaiWrite,
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
        DubbingRead,
        /// <summary>
        /// 
        /// </summary>
        DubbingWrite,
        /// <summary>
        /// 
        /// </summary>
        ForcedAlignment,
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
        ModelsRead,
        /// <summary>
        /// 
        /// </summary>
        ModelsWrite,
        /// <summary>
        /// 
        /// </summary>
        MusicGeneration,
        /// <summary>
        /// 
        /// </summary>
        ProjectsRead,
        /// <summary>
        /// 
        /// </summary>
        ProjectsWrite,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionariesRead,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionariesWrite,
        /// <summary>
        /// 
        /// </summary>
        PublishVoiceToVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountWrite,
        /// <summary>
        /// 
        /// </summary>
        ShareVoiceExternally,
        /// <summary>
        /// 
        /// </summary>
        SoundGeneration,
        /// <summary>
        /// 
        /// </summary>
        SpeechHistoryRead,
        /// <summary>
        /// 
        /// </summary>
        SpeechHistoryWrite,
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
        UserRead,
        /// <summary>
        /// 
        /// </summary>
        UserWrite,
        /// <summary>
        /// 
        /// </summary>
        VoiceGeneration,
        /// <summary>
        /// 
        /// </summary>
        VoicesRead,
        /// <summary>
        /// 
        /// </summary>
        VoicesWrite,
        /// <summary>
        /// 
        /// </summary>
        WebhooksWrite,
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
        WorkspaceMembersRead,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMembersRemove,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceRead,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionType value)
        {
            return value switch
            {
                PermissionType.AddVoiceFromVoiceLibrary => "add_voice_from_voice_library",
                PermissionType.AudioIsolation => "audio_isolation",
                PermissionType.AudioNativeRead => "audio_native_read",
                PermissionType.AudioNativeWrite => "audio_native_write",
                PermissionType.ConvaiRead => "convai_read",
                PermissionType.ConvaiWrite => "convai_write",
                PermissionType.CreateInstantVoiceClone => "create_instant_voice_clone",
                PermissionType.CreateProfessionalVoiceClone => "create_professional_voice_clone",
                PermissionType.CreateUserApiKey => "create_user_api_key",
                PermissionType.DubbingRead => "dubbing_read",
                PermissionType.DubbingWrite => "dubbing_write",
                PermissionType.ForcedAlignment => "forced_alignment",
                PermissionType.GroupMembersManage => "group_members_manage",
                PermissionType.ImageVideoGeneration => "image_video_generation",
                PermissionType.ModelsRead => "models_read",
                PermissionType.ModelsWrite => "models_write",
                PermissionType.MusicGeneration => "music_generation",
                PermissionType.ProjectsRead => "projects_read",
                PermissionType.ProjectsWrite => "projects_write",
                PermissionType.PronunciationDictionariesRead => "pronunciation_dictionaries_read",
                PermissionType.PronunciationDictionariesWrite => "pronunciation_dictionaries_write",
                PermissionType.PublishVoiceToVoiceLibrary => "publish_voice_to_voice_library",
                PermissionType.ServiceAccountWrite => "service_account_write",
                PermissionType.ShareVoiceExternally => "share_voice_externally",
                PermissionType.SoundGeneration => "sound_generation",
                PermissionType.SpeechHistoryRead => "speech_history_read",
                PermissionType.SpeechHistoryWrite => "speech_history_write",
                PermissionType.SpeechToSpeech => "speech_to_speech",
                PermissionType.SpeechToText => "speech_to_text",
                PermissionType.TermsOfServiceAccept => "terms_of_service_accept",
                PermissionType.TextToSpeech => "text_to_speech",
                PermissionType.UserRead => "user_read",
                PermissionType.UserWrite => "user_write",
                PermissionType.VoiceGeneration => "voice_generation",
                PermissionType.VoicesRead => "voices_read",
                PermissionType.VoicesWrite => "voices_write",
                PermissionType.WebhooksWrite => "webhooks_write",
                PermissionType.WorkspaceAnalyticsFullRead => "workspace_analytics_full_read",
                PermissionType.WorkspaceMembersInvite => "workspace_members_invite",
                PermissionType.WorkspaceMembersRead => "workspace_members_read",
                PermissionType.WorkspaceMembersRemove => "workspace_members_remove",
                PermissionType.WorkspaceRead => "workspace_read",
                PermissionType.WorkspaceWrite => "workspace_write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionType? ToEnum(string value)
        {
            return value switch
            {
                "add_voice_from_voice_library" => PermissionType.AddVoiceFromVoiceLibrary,
                "audio_isolation" => PermissionType.AudioIsolation,
                "audio_native_read" => PermissionType.AudioNativeRead,
                "audio_native_write" => PermissionType.AudioNativeWrite,
                "convai_read" => PermissionType.ConvaiRead,
                "convai_write" => PermissionType.ConvaiWrite,
                "create_instant_voice_clone" => PermissionType.CreateInstantVoiceClone,
                "create_professional_voice_clone" => PermissionType.CreateProfessionalVoiceClone,
                "create_user_api_key" => PermissionType.CreateUserApiKey,
                "dubbing_read" => PermissionType.DubbingRead,
                "dubbing_write" => PermissionType.DubbingWrite,
                "forced_alignment" => PermissionType.ForcedAlignment,
                "group_members_manage" => PermissionType.GroupMembersManage,
                "image_video_generation" => PermissionType.ImageVideoGeneration,
                "models_read" => PermissionType.ModelsRead,
                "models_write" => PermissionType.ModelsWrite,
                "music_generation" => PermissionType.MusicGeneration,
                "projects_read" => PermissionType.ProjectsRead,
                "projects_write" => PermissionType.ProjectsWrite,
                "pronunciation_dictionaries_read" => PermissionType.PronunciationDictionariesRead,
                "pronunciation_dictionaries_write" => PermissionType.PronunciationDictionariesWrite,
                "publish_voice_to_voice_library" => PermissionType.PublishVoiceToVoiceLibrary,
                "service_account_write" => PermissionType.ServiceAccountWrite,
                "share_voice_externally" => PermissionType.ShareVoiceExternally,
                "sound_generation" => PermissionType.SoundGeneration,
                "speech_history_read" => PermissionType.SpeechHistoryRead,
                "speech_history_write" => PermissionType.SpeechHistoryWrite,
                "speech_to_speech" => PermissionType.SpeechToSpeech,
                "speech_to_text" => PermissionType.SpeechToText,
                "terms_of_service_accept" => PermissionType.TermsOfServiceAccept,
                "text_to_speech" => PermissionType.TextToSpeech,
                "user_read" => PermissionType.UserRead,
                "user_write" => PermissionType.UserWrite,
                "voice_generation" => PermissionType.VoiceGeneration,
                "voices_read" => PermissionType.VoicesRead,
                "voices_write" => PermissionType.VoicesWrite,
                "webhooks_write" => PermissionType.WebhooksWrite,
                "workspace_analytics_full_read" => PermissionType.WorkspaceAnalyticsFullRead,
                "workspace_members_invite" => PermissionType.WorkspaceMembersInvite,
                "workspace_members_read" => PermissionType.WorkspaceMembersRead,
                "workspace_members_remove" => PermissionType.WorkspaceMembersRemove,
                "workspace_read" => PermissionType.WorkspaceRead,
                "workspace_write" => PermissionType.WorkspaceWrite,
                _ => null,
            };
        }
    }
}