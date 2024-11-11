//HintName: G.Models.ModelResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_be_finetuned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanBeFinetuned { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_do_text_to_speech", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanDoTextToSpeech { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_do_voice_conversion", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanDoVoiceConversion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_style", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseStyle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_speaker_boost", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseSpeakerBoost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serves_pro_voices", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ServesProVoices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_cost_factor", Required = global::Newtonsoft.Json.Required.Always)]
        public double TokenCostFactor { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_alpha_access", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequiresAlphaAccess { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_characters_request_free_user", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxCharactersRequestFreeUser { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_characters_request_subscribed_user", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxCharactersRequestSubscribedUser { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_text_length_per_request", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaximumTextLengthPerRequest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LanguageResponseModel> Languages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_rates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelRatesResponseModel ModelRates { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concurrency_group", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelResponseModelConcurrencyGroup ConcurrencyGroup { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseModel" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="name"></param>
        /// <param name="canBeFinetuned"></param>
        /// <param name="canDoTextToSpeech"></param>
        /// <param name="canDoVoiceConversion"></param>
        /// <param name="canUseStyle"></param>
        /// <param name="canUseSpeakerBoost"></param>
        /// <param name="servesProVoices"></param>
        /// <param name="tokenCostFactor"></param>
        /// <param name="description"></param>
        /// <param name="requiresAlphaAccess"></param>
        /// <param name="maxCharactersRequestFreeUser"></param>
        /// <param name="maxCharactersRequestSubscribedUser"></param>
        /// <param name="maximumTextLengthPerRequest"></param>
        /// <param name="languages"></param>
        /// <param name="modelRates"></param>
        /// <param name="concurrencyGroup"></param>
        public ModelResponseModel(
            string modelId,
            string name,
            bool canBeFinetuned,
            bool canDoTextToSpeech,
            bool canDoVoiceConversion,
            bool canUseStyle,
            bool canUseSpeakerBoost,
            bool servesProVoices,
            double tokenCostFactor,
            string description,
            bool requiresAlphaAccess,
            int maxCharactersRequestFreeUser,
            int maxCharactersRequestSubscribedUser,
            int maximumTextLengthPerRequest,
            global::System.Collections.Generic.IList<global::G.LanguageResponseModel> languages,
            global::G.ModelRatesResponseModel modelRates,
            global::G.ModelResponseModelConcurrencyGroup concurrencyGroup)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CanBeFinetuned = canBeFinetuned;
            this.CanDoTextToSpeech = canDoTextToSpeech;
            this.CanDoVoiceConversion = canDoVoiceConversion;
            this.CanUseStyle = canUseStyle;
            this.CanUseSpeakerBoost = canUseSpeakerBoost;
            this.ServesProVoices = servesProVoices;
            this.TokenCostFactor = tokenCostFactor;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.RequiresAlphaAccess = requiresAlphaAccess;
            this.MaxCharactersRequestFreeUser = maxCharactersRequestFreeUser;
            this.MaxCharactersRequestSubscribedUser = maxCharactersRequestSubscribedUser;
            this.MaximumTextLengthPerRequest = maximumTextLengthPerRequest;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.ModelRates = modelRates ?? throw new global::System.ArgumentNullException(nameof(modelRates));
            this.ConcurrencyGroup = concurrencyGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseModel" /> class.
        /// </summary>
        public ModelResponseModel()
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
        public static global::G.ModelResponseModel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ModelResponseModel>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ModelResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ModelResponseModel?>(serializer.Deserialize<global::G.ModelResponseModel>(jsonReader));
        }

    }
}