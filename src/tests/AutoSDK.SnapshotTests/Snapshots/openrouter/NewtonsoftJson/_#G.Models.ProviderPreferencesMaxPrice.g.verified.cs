//HintName: G.Models.ProviderPreferencesMaxPrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
    /// </summary>
    public sealed partial class ProviderPreferencesMaxPrice
    {
        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion")]
        public global::G.ProviderPreferencesMaxPriceCompletion? Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.ProviderPreferencesMaxPriceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.ProviderPreferencesMaxPriceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.ProviderPreferencesMaxPriceRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderPreferencesMaxPrice" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="completion"></param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
        /// <param name="request"></param>
        public ProviderPreferencesMaxPrice(
            string? prompt,
            global::G.ProviderPreferencesMaxPriceCompletion? completion,
            global::G.ProviderPreferencesMaxPriceImage? image,
            global::G.ProviderPreferencesMaxPriceAudio? audio,
            global::G.ProviderPreferencesMaxPriceRequest? request)
        {
            this.Prompt = prompt;
            this.Completion = completion;
            this.Image = image;
            this.Audio = audio;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderPreferencesMaxPrice" /> class.
        /// </summary>
        public ProviderPreferencesMaxPrice()
        {
        }
    }
}