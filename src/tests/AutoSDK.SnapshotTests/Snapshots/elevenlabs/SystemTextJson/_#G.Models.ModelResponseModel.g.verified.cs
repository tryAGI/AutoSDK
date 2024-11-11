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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_finetuned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeFinetuned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_do_text_to_speech")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanDoTextToSpeech { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_do_voice_conversion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanDoVoiceConversion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_speaker_boost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseSpeakerBoost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serves_pro_voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ServesProVoices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_cost_factor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenCostFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_alpha_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresAlphaAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters_request_free_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCharactersRequestFreeUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters_request_subscribed_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCharactersRequestSubscribedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_text_length_per_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaximumTextLengthPerRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LanguageResponseModel> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_rates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelRatesResponseModel ModelRates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelResponseModelConcurrencyGroupJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelResponseModelConcurrencyGroup ConcurrencyGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
    }
}