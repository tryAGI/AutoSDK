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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public global::G.ProviderPreferencesMaxPriceCompletion? Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::G.ProviderPreferencesMaxPriceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.ProviderPreferencesMaxPriceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.ProviderPreferencesMaxPriceRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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