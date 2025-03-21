//HintName: G.Models.StaticChunkingStrategyRequestParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Customize your own chunking strategy by setting chunk size and chunk overlap.
    /// </summary>
    public sealed partial class StaticChunkingStrategyRequestParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("static", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StaticChunkingStrategy Static { get; set; } = default!;

        /// <summary>
        /// Always `static`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.StaticChunkingStrategyRequestParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyRequestParam" /> class.
        /// </summary>
        /// <param name="static"></param>
        /// <param name="type">
        /// Always `static`.
        /// </param>
        public StaticChunkingStrategyRequestParam(
            global::G.StaticChunkingStrategy @static,
            global::G.StaticChunkingStrategyRequestParamType type)
        {
            this.Static = @static ?? throw new global::System.ArgumentNullException(nameof(@static));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyRequestParam" /> class.
        /// </summary>
        public StaticChunkingStrategyRequestParam()
        {
        }
    }
}