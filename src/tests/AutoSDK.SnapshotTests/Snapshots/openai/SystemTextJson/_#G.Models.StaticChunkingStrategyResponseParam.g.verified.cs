//HintName: G.Models.StaticChunkingStrategyResponseParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StaticChunkingStrategyResponseParam
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter))]
        public global::G.StaticChunkingStrategyResponseParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyResponseParam" /> class.
        /// </summary>
        /// <param name="static"></param>
        /// <param name="type">
        /// Always `static`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StaticChunkingStrategyResponseParam(
            global::G.StaticChunkingStrategy @static,
            global::G.StaticChunkingStrategyResponseParamType type)
        {
            this.Static = @static ?? throw new global::System.ArgumentNullException(nameof(@static));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyResponseParam" /> class.
        /// </summary>
        public StaticChunkingStrategyResponseParam()
        {
        }
    }
}