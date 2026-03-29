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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicPricingPrompt Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicPricingCompletion Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.PublicPricingRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::G.PublicPricingImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        public global::G.PublicPricingImageToken? ImageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_output")]
        public global::G.PublicPricingImageOutput? ImageOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.PublicPricingAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_output")]
        public global::G.PublicPricingAudioOutput? AudioOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public global::G.PublicPricingInputAudioCache? InputAudioCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public global::G.PublicPricingWebSearch? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reasoning")]
        public global::G.PublicPricingInternalReasoning? InternalReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public global::G.PublicPricingInputCacheRead? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public global::G.PublicPricingInputCacheWrite? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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