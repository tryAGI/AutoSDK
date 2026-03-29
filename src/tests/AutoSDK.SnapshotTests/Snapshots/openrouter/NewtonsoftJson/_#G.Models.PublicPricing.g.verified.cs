//HintName: G.Models.PublicPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pricing information for the model
    /// </summary>
    public sealed partial class PublicPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicPricingPrompt Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicPricingCompletion Completion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.PublicPricingRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.PublicPricingImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_token")]
        public global::G.PublicPricingImageToken? ImageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_output")]
        public global::G.PublicPricingImageOutput? ImageOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.PublicPricingAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_output")]
        public global::G.PublicPricingAudioOutput? AudioOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_cache")]
        public global::G.PublicPricingInputAudioCache? InputAudioCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_search")]
        public global::G.PublicPricingWebSearch? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("internal_reasoning")]
        public global::G.PublicPricingInternalReasoning? InternalReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_cache_read")]
        public global::G.PublicPricingInputCacheRead? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_cache_write")]
        public global::G.PublicPricingInputCacheWrite? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="completion"></param>
        /// <param name="request"></param>
        /// <param name="image"></param>
        /// <param name="imageToken"></param>
        /// <param name="imageOutput"></param>
        /// <param name="audio"></param>
        /// <param name="audioOutput"></param>
        /// <param name="inputAudioCache"></param>
        /// <param name="webSearch"></param>
        /// <param name="internalReasoning"></param>
        /// <param name="inputCacheRead"></param>
        /// <param name="inputCacheWrite"></param>
        /// <param name="discount"></param>
        public PublicPricing(
            global::G.PublicPricingPrompt prompt,
            global::G.PublicPricingCompletion completion,
            global::G.PublicPricingRequest? request,
            global::G.PublicPricingImage? image,
            global::G.PublicPricingImageToken? imageToken,
            global::G.PublicPricingImageOutput? imageOutput,
            global::G.PublicPricingAudio? audio,
            global::G.PublicPricingAudioOutput? audioOutput,
            global::G.PublicPricingInputAudioCache? inputAudioCache,
            global::G.PublicPricingWebSearch? webSearch,
            global::G.PublicPricingInternalReasoning? internalReasoning,
            global::G.PublicPricingInputCacheRead? inputCacheRead,
            global::G.PublicPricingInputCacheWrite? inputCacheWrite,
            double? discount)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Request = request;
            this.Image = image;
            this.ImageToken = imageToken;
            this.ImageOutput = imageOutput;
            this.Audio = audio;
            this.AudioOutput = audioOutput;
            this.InputAudioCache = inputAudioCache;
            this.WebSearch = webSearch;
            this.InternalReasoning = internalReasoning;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.Discount = discount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        public PublicPricing()
        {
        }
    }
}