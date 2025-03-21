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
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StaticChunkingStrategy Static { get; set; }

        /// <summary>
        /// Always `static`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter))]
        public global::G.StaticChunkingStrategyRequestParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyRequestParam" /> class.
        /// </summary>
        /// <param name="static"></param>
        /// <param name="type">
        /// Always `static`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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