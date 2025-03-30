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
        /// The unique identifier of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the model can be finetuned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_finetuned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeFinetuned { get; set; }

        /// <summary>
        /// Whether the model can do text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_do_text_to_speech")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanDoTextToSpeech { get; set; }

        /// <summary>
        /// Whether the model can do voice conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_do_voice_conversion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanDoVoiceConversion { get; set; }

        /// <summary>
        /// Whether the model can use style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseStyle { get; set; }

        /// <summary>
        /// Whether the model can use speaker boost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_speaker_boost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseSpeakerBoost { get; set; }

        /// <summary>
        /// Whether the model serves pro voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serves_pro_voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ServesProVoices { get; set; }

        /// <summary>
        /// The cost factor for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_cost_factor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenCostFactor { get; set; }

        /// <summary>
        /// The description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the model requires alpha access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_alpha_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresAlphaAccess { get; set; }

        /// <summary>
        /// The maximum number of characters that can be requested by a free user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters_request_free_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCharactersRequestFreeUser { get; set; }

        /// <summary>
        /// The maximum number of characters that can be requested by a subscribed user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters_request_subscribed_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCharactersRequestSubscribedUser { get; set; }

        /// <summary>
        /// The maximum length of text that can be requested for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_text_length_per_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaximumTextLengthPerRequest { get; set; }

        /// <summary>
        /// The languages supported by the model.
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
        /// The concurrency group for the model.
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
        /// <param name="modelId">
        /// The unique identifier of the model.
        /// </param>
        /// <param name="name">
        /// The name of the model.
        /// </param>
        /// <param name="canBeFinetuned">
        /// Whether the model can be finetuned.
        /// </param>
        /// <param name="canDoTextToSpeech">
        /// Whether the model can do text-to-speech.
        /// </param>
        /// <param name="canDoVoiceConversion">
        /// Whether the model can do voice conversion.
        /// </param>
        /// <param name="canUseStyle">
        /// Whether the model can use style.
        /// </param>
        /// <param name="canUseSpeakerBoost">
        /// Whether the model can use speaker boost.
        /// </param>
        /// <param name="servesProVoices">
        /// Whether the model serves pro voices.
        /// </param>
        /// <param name="tokenCostFactor">
        /// The cost factor for the model.
        /// </param>
        /// <param name="description">
        /// The description of the model.
        /// </param>
        /// <param name="requiresAlphaAccess">
        /// Whether the model requires alpha access.
        /// </param>
        /// <param name="maxCharactersRequestFreeUser">
        /// The maximum number of characters that can be requested by a free user.
        /// </param>
        /// <param name="maxCharactersRequestSubscribedUser">
        /// The maximum number of characters that can be requested by a subscribed user.
        /// </param>
        /// <param name="maximumTextLengthPerRequest">
        /// The maximum length of text that can be requested for this model.
        /// </param>
        /// <param name="languages">
        /// The languages supported by the model.
        /// </param>
        /// <param name="modelRates"></param>
        /// <param name="concurrencyGroup">
        /// The concurrency group for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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