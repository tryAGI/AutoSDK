//HintName: G.Models.MessagesRequestProviderMaxPrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
    /// </summary>
    public sealed partial class MessagesRequestProviderMaxPrice
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
        public global::G.MessagesRequestProviderMaxPriceCompletion? Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.MessagesRequestProviderMaxPriceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.MessagesRequestProviderMaxPriceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.MessagesRequestProviderMaxPriceRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestProviderMaxPrice" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="completion"></param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
        /// <param name="request"></param>
        public MessagesRequestProviderMaxPrice(
            string? prompt,
            global::G.MessagesRequestProviderMaxPriceCompletion? completion,
            global::G.MessagesRequestProviderMaxPriceImage? image,
            global::G.MessagesRequestProviderMaxPriceAudio? audio,
            global::G.MessagesRequestProviderMaxPriceRequest? request)
        {
            this.Prompt = prompt;
            this.Completion = completion;
            this.Image = image;
            this.Audio = audio;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestProviderMaxPrice" /> class.
        /// </summary>
        public MessagesRequestProviderMaxPrice()
        {
        }
    }
}