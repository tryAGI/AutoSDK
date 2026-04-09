//HintName: G.Models.RequestImageBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestImageBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlVariant115? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RequestImageBlockTypeJsonConverter))]
        public global::G.RequestImageBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source4 Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestImageBlock" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        public RequestImageBlock(
            global::G.Source4 source,
            global::G.CacheControlVariant115? cacheControl,
            global::G.RequestImageBlockType type)
        {
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestImageBlock" /> class.
        /// </summary>
        public RequestImageBlock()
        {
        }
    }
}