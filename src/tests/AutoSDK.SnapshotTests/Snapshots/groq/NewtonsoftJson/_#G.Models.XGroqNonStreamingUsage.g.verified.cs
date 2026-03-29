//HintName: G.Models.XGroqNonStreamingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional Groq-specific usage metrics (hardware cache statistics).
    /// </summary>
    public sealed partial class XGroqNonStreamingUsage
    {
        /// <summary>
        /// Number of tokens served from SRAM cache.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sram_cached_tokens")]
        public int? SramCachedTokens { get; set; }

        /// <summary>
        /// Number of tokens served from DRAM cache.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dram_cached_tokens")]
        public int? DramCachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroqNonStreamingUsage" /> class.
        /// </summary>
        /// <param name="sramCachedTokens">
        /// Number of tokens served from SRAM cache.
        /// </param>
        /// <param name="dramCachedTokens">
        /// Number of tokens served from DRAM cache.
        /// </param>
        public XGroqNonStreamingUsage(
            int? sramCachedTokens,
            int? dramCachedTokens)
        {
            this.SramCachedTokens = sramCachedTokens;
            this.DramCachedTokens = dramCachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroqNonStreamingUsage" /> class.
        /// </summary>
        public XGroqNonStreamingUsage()
        {
        }
    }
}