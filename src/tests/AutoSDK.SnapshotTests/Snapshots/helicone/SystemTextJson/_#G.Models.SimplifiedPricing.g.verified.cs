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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.SimplifiedModalityPricing? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public double? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public double? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::G.SimplifiedModalityPricing? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::G.SimplifiedModalityPricing? Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::G.SimplifiedModalityPricing? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheRead")]
        public double? CacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWrite")]
        public double? CacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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