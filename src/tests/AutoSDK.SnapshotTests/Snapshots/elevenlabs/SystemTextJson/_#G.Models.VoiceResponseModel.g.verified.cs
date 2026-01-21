//HintName: G.Models.VoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"available_for_tiers":["creator","enterprise"],"category":"professional","description":"A warm, expressive voice with a touch of humor.","fine_tuning":{"is_allowed_to_fine_tune":true,"manual_verification_requested":false,"state":{"eleven_multilingual_v2":"fine_tuned"},"verification_attempts_count":2,"verification_failures":[]},"high_quality_base_model_ids":["eleven_v2_flash","eleven_flash_v2","eleven_turbo_v2_5","eleven_multilingual_v2","eleven_v2_5_flash","eleven_flash_v2_5","eleven_turbo_v2"],"is_legacy":false,"is_mixed":false,"is_owner":false,"labels":{"accent":"American","age":"middle-aged","description":"expressive","gender":"female","use_case":"social media"},"name":"Rachel","preview_url":"https://storage.googleapis.com/eleven-public-prod/premade/voices/9BWtsMINqrJLrRacOk9x/405766b8-1f4e-4d3c-aba1-6f25333823ec.mp3","settings":{"similarity_boost":1,"speed":1,"stability":1,"style":0,"use_speaker_boost":true},"sharing":{"category":"professional","cloned_by_count":50,"date_unix":1714204800,"description":"A female voice with a soft and friendly tone.","disable_at_unix":1714204800,"enabled_in_library":true,"featured":true,"financial_rewards_enabled":true,"free_users_allowed":true,"history_item_sample_id":"DCwhRBWXzGAHq8TQ4Fs18","labels":{"accent":"American","gender":"female"},"liked_by_count":100,"live_moderation_enabled":true,"moderation_check":{"captcha_checks":[0.95,0.98],"captcha_ids":["captcha1","captcha2"],"date_checked_unix":1714204800,"description_check":true,"description_value":"A female voice with a soft and friendly tone.","name_check":true,"name_value":"Rachel","sample_checks":[0.95,0.98],"sample_ids":["sample1","sample2"]},"name":"Rachel","notice_period":30,"original_voice_id":"DCwhRBWXzGAHq8TQ4Fs18","public_owner_id":"DCwhRBWXzGAHq8TQ4Fs18","rate":0.05,"reader_app_enabled":true,"reader_restricted_on":[{"resource_id":"FCwhRBWXzGAHq8TQ4Fs18","resource_type":"read"}],"review_status":"allowed","status":"enabled","voice_mixing_allowed":false,"whitelisted_emails":["example@example.com"]},"verified_languages":{"accent":"American","language":"en","model_id":"eleven_turbo_v2_5"},"voice_id":"21m00Tcm4TlvDq8ikWAM","voice_verification":{"is_verified":true,"language":"en","requires_verification":false,"verification_attempts":[{"accepted":true,"date_unix":1714204800,"levenshtein_distance":2,"recording":{"mime_type":"audio/mpeg","recording_id":"CwhRBWXzGAHq8TQ4Fs17","size_bytes":1000000,"transcription":"Hello, how are you?","upload_date_unix":1714204800},"similarity":0.95,"text":"Hello, how are you?"}],"verification_attempts_count":0,"verification_failures":[]}}
    /// </summary>
    public sealed partial class VoiceResponseModel
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of samples associated with the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::G.SampleResponseModel>? Samples { get; set; }

        /// <summary>
        /// The category of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceResponseModelCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceResponseModelCategory Category { get; set; }

        /// <summary>
        /// Fine-tuning information for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuning")]
        public global::G.FineTuningResponseModel? FineTuning { get; set; }

        /// <summary>
        /// Labels associated with the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The preview URL of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The tiers the voice is available for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_for_tiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableForTiers { get; set; }

        /// <summary>
        /// The settings of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::G.VoiceSettingsResponseModel? Settings { get; set; }

        /// <summary>
        /// The sharing information of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::G.VoiceSharingResponseModel? Sharing { get; set; }

        /// <summary>
        /// The base model IDs for high-quality voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_quality_base_model_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HighQualityBaseModelIds { get; set; }

        /// <summary>
        /// The verified languages of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_languages")]
        public global::System.Collections.Generic.IList<global::G.VerifiedVoiceLanguageResponseModel>? VerifiedLanguages { get; set; }

        /// <summary>
        /// The safety controls of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_control")]
        public global::G.VoiceResponseModelSafetyControl2? SafetyControl { get; set; }

        /// <summary>
        /// The voice verification of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_verification")]
        public global::G.VoiceVerificationResponseModel? VoiceVerification { get; set; }

        /// <summary>
        /// The permission on the resource of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        public string? PermissionOnResource { get; set; }

        /// <summary>
        /// Whether the voice is owned by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// Whether the voice is legacy.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_legacy")]
        public bool? IsLegacy { get; set; }

        /// <summary>
        /// Whether the voice is mixed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_mixed")]
        public bool? IsMixed { get; set; }

        /// <summary>
        /// The creation time of the voice in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="samples">
        /// List of samples associated with the voice.
        /// </param>
        /// <param name="category">
        /// The category of the voice.
        /// </param>
        /// <param name="fineTuning">
        /// Fine-tuning information for the voice.
        /// </param>
        /// <param name="labels">
        /// Labels associated with the voice.
        /// </param>
        /// <param name="description">
        /// The description of the voice.
        /// </param>
        /// <param name="previewUrl">
        /// The preview URL of the voice.
        /// </param>
        /// <param name="availableForTiers">
        /// The tiers the voice is available for.
        /// </param>
        /// <param name="settings">
        /// The settings of the voice.
        /// </param>
        /// <param name="sharing">
        /// The sharing information of the voice.
        /// </param>
        /// <param name="highQualityBaseModelIds">
        /// The base model IDs for high-quality voices.
        /// </param>
        /// <param name="verifiedLanguages">
        /// The verified languages of the voice.
        /// </param>
        /// <param name="safetyControl">
        /// The safety controls of the voice.
        /// </param>
        /// <param name="voiceVerification">
        /// The voice verification of the voice.
        /// </param>
        /// <param name="permissionOnResource">
        /// The permission on the resource of the voice.
        /// </param>
        /// <param name="isOwner">
        /// Whether the voice is owned by the user.
        /// </param>
        /// <param name="isLegacy">
        /// Whether the voice is legacy.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isMixed">
        /// Whether the voice is mixed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAtUnix">
        /// The creation time of the voice in Unix time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceResponseModel(
            string voiceId,
            string name,
            global::G.VoiceResponseModelCategory category,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            global::System.Collections.Generic.IList<string> availableForTiers,
            global::System.Collections.Generic.IList<string> highQualityBaseModelIds,
            global::System.Collections.Generic.IList<global::G.SampleResponseModel>? samples,
            global::G.FineTuningResponseModel? fineTuning,
            string? description,
            string? previewUrl,
            global::G.VoiceSettingsResponseModel? settings,
            global::G.VoiceSharingResponseModel? sharing,
            global::System.Collections.Generic.IList<global::G.VerifiedVoiceLanguageResponseModel>? verifiedLanguages,
            global::G.VoiceResponseModelSafetyControl2? safetyControl,
            global::G.VoiceVerificationResponseModel? voiceVerification,
            string? permissionOnResource,
            bool? isOwner,
            bool? isLegacy,
            bool? isMixed,
            int? createdAtUnix)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Category = category;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.AvailableForTiers = availableForTiers ?? throw new global::System.ArgumentNullException(nameof(availableForTiers));
            this.HighQualityBaseModelIds = highQualityBaseModelIds ?? throw new global::System.ArgumentNullException(nameof(highQualityBaseModelIds));
            this.Samples = samples;
            this.FineTuning = fineTuning;
            this.Description = description;
            this.PreviewUrl = previewUrl;
            this.Settings = settings;
            this.Sharing = sharing;
            this.VerifiedLanguages = verifiedLanguages;
            this.SafetyControl = safetyControl;
            this.VoiceVerification = voiceVerification;
            this.PermissionOnResource = permissionOnResource;
            this.IsOwner = isOwner;
            this.IsLegacy = isLegacy;
            this.IsMixed = isMixed;
            this.CreatedAtUnix = createdAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponseModel" /> class.
        /// </summary>
        public VoiceResponseModel()
        {
        }
    }
}