//HintName: G.Models.PromptCachingBetaRequestImageBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCachingBetaRequestImageBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptCachingBetaRequestImageBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Base64ImageSource Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestImageBlock" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="source"></param>
        public PromptCachingBetaRequestImageBlock(
            global::G.Base64ImageSource source,
            global::G.CacheControlEphemeral? cacheControl,
            global::G.PromptCachingBetaRequestImageBlockType type)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestImageBlock" /> class.
        /// </summary>
        public PromptCachingBetaRequestImageBlock()
        {
        }
    }
}