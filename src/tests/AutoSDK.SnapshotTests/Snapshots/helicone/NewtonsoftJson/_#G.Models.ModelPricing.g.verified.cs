//HintName: G.Models.ModelPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public double Threshold { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public double Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public double Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheMultipliers")]
        public global::G.ModelPricingCacheMultipliers? CacheMultipliers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheStoragePerHour")]
        public double? CacheStoragePerHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking")]
        public double? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public double? Request { get; set; }

        /// <summary>
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.ModalityPricing? Image { get; set; }

        /// <summary>
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.ModalityPricing? Audio { get; set; }

        /// <summary>
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video")]
        public global::G.ModalityPricing? Video { get; set; }

        /// <summary>
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.ModalityPricing? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_search")]
        public double? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        /// <param name="threshold"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="cacheMultipliers"></param>
        /// <param name="cacheStoragePerHour"></param>
        /// <param name="thinking"></param>
        /// <param name="request"></param>
        /// <param name="image">
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </param>
        /// <param name="audio">
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </param>
        /// <param name="video">
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </param>
        /// <param name="file">
        /// Per-modality pricing configuration.<br/>
        /// Supports input, cached input (as multiplier), and output rates.
        /// </param>
        /// <param name="webSearch"></param>
        public ModelPricing(
            double threshold,
            double input,
            double output,
            global::G.ModelPricingCacheMultipliers? cacheMultipliers,
            double? cacheStoragePerHour,
            double? thinking,
            double? request,
            global::G.ModalityPricing? image,
            global::G.ModalityPricing? audio,
            global::G.ModalityPricing? video,
            global::G.ModalityPricing? file,
            double? webSearch)
        {
            this.Threshold = threshold;
            this.Input = input;
            this.Output = output;
            this.CacheMultipliers = cacheMultipliers;
            this.CacheStoragePerHour = cacheStoragePerHour;
            this.Thinking = thinking;
            this.Request = request;
            this.Image = image;
            this.Audio = audio;
            this.Video = video;
            this.File = file;
            this.WebSearch = webSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        public ModelPricing()
        {
        }
    }
}