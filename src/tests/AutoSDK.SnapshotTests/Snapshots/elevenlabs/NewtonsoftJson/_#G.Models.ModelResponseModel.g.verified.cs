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
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// The name of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether the model can be finetuned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_be_finetuned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanBeFinetuned { get; set; } = default!;

        /// <summary>
        /// Whether the model can do text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_do_text_to_speech", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanDoTextToSpeech { get; set; } = default!;

        /// <summary>
        /// Whether the model can do voice conversion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_do_voice_conversion", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanDoVoiceConversion { get; set; } = default!;

        /// <summary>
        /// Whether the model can use style.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_style", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseStyle { get; set; } = default!;

        /// <summary>
        /// Whether the model can use speaker boost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_speaker_boost", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseSpeakerBoost { get; set; } = default!;

        /// <summary>
        /// Whether the model serves pro voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serves_pro_voices", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ServesProVoices { get; set; } = default!;

        /// <summary>
        /// The cost factor for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_cost_factor", Required = global::Newtonsoft.Json.Required.Always)]
        public double TokenCostFactor { get; set; } = default!;

        /// <summary>
        /// The description of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Whether the model requires alpha access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_alpha_access", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequiresAlphaAccess { get; set; } = default!;

        /// <summary>
        /// The maximum number of characters that can be requested by a free user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_characters_request_free_user", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxCharactersRequestFreeUser { get; set; } = default!;

        /// <summary>
        /// The maximum number of characters that can be requested by a subscribed user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_characters_request_subscribed_user", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxCharactersRequestSubscribedUser { get; set; } = default!;

        /// <summary>
        /// The maximum length of text that can be requested for this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_text_length_per_request", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaximumTextLengthPerRequest { get; set; } = default!;

        /// <summary>
        /// The languages supported by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LanguageResponseModel> Languages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_rates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelRatesResponseModel ModelRates { get; set; } = default!;

        /// <summary>
        /// The concurrency group for the model.
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