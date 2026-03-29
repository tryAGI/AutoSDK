//HintName: G.Models.SimplifiedPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimplifiedPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public double Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion", Required = global::Newtonsoft.Json.Required.Always)]
        public double Completion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.SimplifiedModalityPricing? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking")]
        public double? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_search")]
        public double? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.SimplifiedModalityPricing? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video")]
        public global::G.SimplifiedModalityPricing? Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.SimplifiedModalityPricing? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheRead")]
        public double? CacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheWrite")]
        public double? CacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedPricing" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="completion"></param>
        /// <param name="audio"></param>
        /// <param name="thinking"></param>
        /// <param name="webSearch"></param>
        /// <param name="image"></param>
        /// <param name="video"></param>
        /// <param name="file"></param>
        /// <param name="cacheRead"></param>
        /// <param name="cacheWrite"></param>
        /// <param name="threshold"></param>
        public SimplifiedPricing(
            double prompt,
            double completion,
            global::G.SimplifiedModalityPricing? audio,
            double? thinking,
            double? webSearch,
            global::G.SimplifiedModalityPricing? image,
            global::G.SimplifiedModalityPricing? video,
            global::G.SimplifiedModalityPricing? file,
            double? cacheRead,
            double? cacheWrite,
            double? threshold)
        {
            this.Prompt = prompt;
            this.Completion = completion;
            this.Audio = audio;
            this.Thinking = thinking;
            this.WebSearch = webSearch;
            this.Image = image;
            this.Video = video;
            this.File = file;
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedPricing" /> class.
        /// </summary>
        public SimplifiedPricing()
        {
        }
    }
}