//HintName: G.Models.StaticChunkingStrategyRequestParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StaticChunkingStrategyRequestParam
    {
        /// <summary>
        /// Always `static`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter))]
        public global::G.StaticChunkingStrategyRequestParamType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StaticChunkingStrategy Static { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}