//HintName: G.Models.BetaRequestImageBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestImageBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaRequestImageBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source2 Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestImageBlock" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="source"></param>
        public BetaRequestImageBlock(
            global::G.Source2 source,
            global::G.BetaCacheControlEphemeral? cacheControl,
            global::G.BetaRequestImageBlockType type)
        {
            this.Source = source;
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestImageBlock" /> class.
        /// </summary>
        public BetaRequestImageBlock()
        {
        }
    }
}