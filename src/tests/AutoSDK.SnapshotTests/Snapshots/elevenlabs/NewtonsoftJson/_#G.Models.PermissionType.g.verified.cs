//HintName: G.Models.PermissionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PermissionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_to_speech")]
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech_to_speech")]
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech_to_text")]
        SpeechToText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="models_read")]
        ModelsRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="models_write")]
        ModelsWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voices_read")]
        VoicesRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voices_write")]
        VoicesWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech_history_read")]
        SpeechHistoryRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech_history_write")]
        SpeechHistoryWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sound_generation")]
        SoundGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_isolation")]
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_generation")]
        VoiceGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing_read")]
        DubbingRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing_write")]
        DubbingWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pronunciation_dictionaries_read")]
        PronunciationDictionariesRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pronunciation_dictionaries_write")]
        PronunciationDictionariesWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_read")]
        UserRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_write")]
        UserWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="projects_read")]
        ProjectsRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="projects_write")]
        ProjectsWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_native_read")]
        AudioNativeRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_native_write")]
        AudioNativeWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_read")]
        WorkspaceRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_write")]
        WorkspaceWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forced_alignment")]
        ForcedAlignment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_read")]
        ConvaiRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_write")]
        ConvaiWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="music_generation")]
        MusicGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_video_generation")]
        ImageVideoGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add_voice_from_voice_library")]
        AddVoiceFromVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_instant_voice_clone")]
        CreateInstantVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_professional_voice_clone")]
        CreateProfessionalVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="publish_voice_to_voice_library")]
        PublishVoiceToVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="share_voice_externally")]
        ShareVoiceExternally,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_user_api_key")]
        CreateUserApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_analytics_full_read")]
        WorkspaceAnalyticsFullRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhooks_write")]
        WebhooksWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account_write")]
        ServiceAccountWrite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="group_members_manage")]
        GroupMembersManage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_members_read")]
        WorkspaceMembersRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_members_invite")]
        WorkspaceMembersInvite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_members_remove")]
        WorkspaceMembersRemove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="terms_of_service_accept")]
        TermsOfServiceAccept,
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
                PermissionType.TextToSpeech => "text_to_speech",
                PermissionType.SpeechToSpeech => "speech_to_speech",
                PermissionType.SpeechToText => "speech_to_text",
                PermissionType.ModelsRead => "models_read",
                PermissionType.ModelsWrite => "models_write",
                PermissionType.VoicesRead => "voices_read",
                PermissionType.VoicesWrite => "voices_write",
                PermissionType.SpeechHistoryRead => "speech_history_read",
                PermissionType.SpeechHistoryWrite => "speech_history_write",
                PermissionType.SoundGeneration => "sound_generation",
                PermissionType.AudioIsolation => "audio_isolation",
                PermissionType.VoiceGeneration => "voice_generation",
                PermissionType.DubbingRead => "dubbing_read",
                PermissionType.DubbingWrite => "dubbing_write",
                PermissionType.PronunciationDictionariesRead => "pronunciation_dictionaries_read",
                PermissionType.PronunciationDictionariesWrite => "pronunciation_dictionaries_write",
                PermissionType.UserRead => "user_read",
                PermissionType.UserWrite => "user_write",
                PermissionType.ProjectsRead => "projects_read",
                PermissionType.ProjectsWrite => "projects_write",
                PermissionType.AudioNativeRead => "audio_native_read",
                PermissionType.AudioNativeWrite => "audio_native_write",
                PermissionType.WorkspaceRead => "workspace_read",
                PermissionType.WorkspaceWrite => "workspace_write",
                PermissionType.ForcedAlignment => "forced_alignment",
                PermissionType.ConvaiRead => "convai_read",
                PermissionType.ConvaiWrite => "convai_write",
                PermissionType.MusicGeneration => "music_generation",
                PermissionType.ImageVideoGeneration => "image_video_generation",
                PermissionType.AddVoiceFromVoiceLibrary => "add_voice_from_voice_library",
                PermissionType.CreateInstantVoiceClone => "create_instant_voice_clone",
                PermissionType.CreateProfessionalVoiceClone => "create_professional_voice_clone",
                PermissionType.PublishVoiceToVoiceLibrary => "publish_voice_to_voice_library",
                PermissionType.ShareVoiceExternally => "share_voice_externally",
                PermissionType.CreateUserApiKey => "create_user_api_key",
                PermissionType.WorkspaceAnalyticsFullRead => "workspace_analytics_full_read",
                PermissionType.WebhooksWrite => "webhooks_write",
                PermissionType.ServiceAccountWrite => "service_account_write",
                PermissionType.GroupMembersManage => "group_members_manage",
                PermissionType.WorkspaceMembersRead => "workspace_members_read",
                PermissionType.WorkspaceMembersInvite => "workspace_members_invite",
                PermissionType.WorkspaceMembersRemove => "workspace_members_remove",
                PermissionType.TermsOfServiceAccept => "terms_of_service_accept",
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
                "text_to_speech" => PermissionType.TextToSpeech,
                "speech_to_speech" => PermissionType.SpeechToSpeech,
                "speech_to_text" => PermissionType.SpeechToText,
                "models_read" => PermissionType.ModelsRead,
                "models_write" => PermissionType.ModelsWrite,
                "voices_read" => PermissionType.VoicesRead,
                "voices_write" => PermissionType.VoicesWrite,
                "speech_history_read" => PermissionType.SpeechHistoryRead,
                "speech_history_write" => PermissionType.SpeechHistoryWrite,
                "sound_generation" => PermissionType.SoundGeneration,
                "audio_isolation" => PermissionType.AudioIsolation,
                "voice_generation" => PermissionType.VoiceGeneration,
                "dubbing_read" => PermissionType.DubbingRead,
                "dubbing_write" => PermissionType.DubbingWrite,
                "pronunciation_dictionaries_read" => PermissionType.PronunciationDictionariesRead,
                "pronunciation_dictionaries_write" => PermissionType.PronunciationDictionariesWrite,
                "user_read" => PermissionType.UserRead,
                "user_write" => PermissionType.UserWrite,
                "projects_read" => PermissionType.ProjectsRead,
                "projects_write" => PermissionType.ProjectsWrite,
                "audio_native_read" => PermissionType.AudioNativeRead,
                "audio_native_write" => PermissionType.AudioNativeWrite,
                "workspace_read" => PermissionType.WorkspaceRead,
                "workspace_write" => PermissionType.WorkspaceWrite,
                "forced_alignment" => PermissionType.ForcedAlignment,
                "convai_read" => PermissionType.ConvaiRead,
                "convai_write" => PermissionType.ConvaiWrite,
                "music_generation" => PermissionType.MusicGeneration,
                "image_video_generation" => PermissionType.ImageVideoGeneration,
                "add_voice_from_voice_library" => PermissionType.AddVoiceFromVoiceLibrary,
                "create_instant_voice_clone" => PermissionType.CreateInstantVoiceClone,
                "create_professional_voice_clone" => PermissionType.CreateProfessionalVoiceClone,
                "publish_voice_to_voice_library" => PermissionType.PublishVoiceToVoiceLibrary,
                "share_voice_externally" => PermissionType.ShareVoiceExternally,
                "create_user_api_key" => PermissionType.CreateUserApiKey,
                "workspace_analytics_full_read" => PermissionType.WorkspaceAnalyticsFullRead,
                "webhooks_write" => PermissionType.WebhooksWrite,
                "service_account_write" => PermissionType.ServiceAccountWrite,
                "group_members_manage" => PermissionType.GroupMembersManage,
                "workspace_members_read" => PermissionType.WorkspaceMembersRead,
                "workspace_members_invite" => PermissionType.WorkspaceMembersInvite,
                "workspace_members_remove" => PermissionType.WorkspaceMembersRemove,
                "terms_of_service_accept" => PermissionType.TermsOfServiceAccept,
                _ => null,
            };
        }
    }
}