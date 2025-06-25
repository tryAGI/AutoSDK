//HintName: G.Models.VoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::G.VoiceSettingsResponseModel? Settings { get; set; }

        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceResponseModelSafetyControlJsonConverter))]
        public global::G.VoiceResponseModelSafetyControl? SafetyControl { get; set; }

        /// <summary>
        /// 
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
        /// <param name="fineTuning"></param>
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
        /// <param name="settings"></param>
        /// <param name="sharing"></param>
        /// <param name="highQualityBaseModelIds">
        /// The base model IDs for high-quality voices.
        /// </param>
        /// <param name="verifiedLanguages">
        /// The verified languages of the voice.
        /// </param>
        /// <param name="safetyControl">
        /// The safety controls of the voice.
        /// </param>
        /// <param name="voiceVerification"></param>
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
            global::G.VoiceResponseModelSafetyControl? safetyControl,
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