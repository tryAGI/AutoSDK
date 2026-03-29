//HintName: G.Models.ResponsesRequestProviderMaxPrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
    /// </summary>
    public sealed partial class ResponsesRequestProviderMaxPrice
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
        public global::G.ResponsesRequestProviderMaxPriceCompletion? Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.ResponsesRequestProviderMaxPriceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.ResponsesRequestProviderMaxPriceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.ResponsesRequestProviderMaxPriceRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestProviderMaxPrice" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="completion"></param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
        /// <param name="request"></param>
        public ResponsesRequestProviderMaxPrice(
            string? prompt,
            global::G.ResponsesRequestProviderMaxPriceCompletion? completion,
            global::G.ResponsesRequestProviderMaxPriceImage? image,
            global::G.ResponsesRequestProviderMaxPriceAudio? audio,
            global::G.ResponsesRequestProviderMaxPriceRequest? request)
        {
            this.Prompt = prompt;
            this.Completion = completion;
            this.Image = image;
            this.Audio = audio;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestProviderMaxPrice" /> class.
        /// </summary>
        public ResponsesRequestProviderMaxPrice()
        {
        }
    }
}