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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("samples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SampleResponseModel> Samples { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceResponseModelCategory Category { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuning", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningResponseModel FineTuning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("available_for_tiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AvailableForTiers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceSettingsResponseModel Settings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sharing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceSharingResponseModel Sharing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("high_quality_base_model_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> HighQualityBaseModelIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safety_control")]
        public global::G.VoiceResponseModelSafetyControl? SafetyControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_verification")]
        public global::G.VoiceVerificationResponseModel? VoiceVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_on_resource")]
        public string? PermissionOnResource { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_legacy")]
        public bool? IsLegacy { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_mixed")]
        public bool? IsMixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="samples"></param>
        /// <param name="category"></param>
        /// <param name="fineTuning"></param>
        /// <param name="labels"></param>
        /// <param name="description"></param>
        /// <param name="previewUrl"></param>
        /// <param name="availableForTiers"></param>
        /// <param name="settings"></param>
        /// <param name="sharing"></param>
        /// <param name="highQualityBaseModelIds"></param>
        /// <param name="safetyControl"></param>
        /// <param name="voiceVerification"></param>
        /// <param name="permissionOnResource"></param>
        /// <param name="isLegacy">
        /// Default Value: false
        /// </param>
        /// <param name="isMixed">
        /// Default Value: false
        /// </param>
        public VoiceResponseModel(
            string voiceId,
            string name,
            global::System.Collections.Generic.IList<global::G.SampleResponseModel> samples,
            global::G.VoiceResponseModelCategory category,
            global::G.FineTuningResponseModel fineTuning,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            string description,
            string previewUrl,
            global::System.Collections.Generic.IList<string> availableForTiers,
            global::G.VoiceSettingsResponseModel settings,
            global::G.VoiceSharingResponseModel sharing,
            global::System.Collections.Generic.IList<string> highQualityBaseModelIds,
            global::G.VoiceResponseModelSafetyControl? safetyControl,
            global::G.VoiceVerificationResponseModel? voiceVerification,
            string? permissionOnResource,
            bool? isLegacy,
            bool? isMixed)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
            this.Category = category;
            this.FineTuning = fineTuning ?? throw new global::System.ArgumentNullException(nameof(fineTuning));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.AvailableForTiers = availableForTiers ?? throw new global::System.ArgumentNullException(nameof(availableForTiers));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Sharing = sharing ?? throw new global::System.ArgumentNullException(nameof(sharing));
            this.HighQualityBaseModelIds = highQualityBaseModelIds ?? throw new global::System.ArgumentNullException(nameof(highQualityBaseModelIds));
            this.SafetyControl = safetyControl;
            this.VoiceVerification = voiceVerification;
            this.PermissionOnResource = permissionOnResource;
            this.IsLegacy = isLegacy;
            this.IsMixed = isMixed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponseModel" /> class.
        /// </summary>
        public VoiceResponseModel()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.VoiceResponseModel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.VoiceResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.VoiceResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.VoiceResponseModel?>(serializer.Deserialize<global::G.VoiceResponseModel>(jsonReader));
        }

    }
}