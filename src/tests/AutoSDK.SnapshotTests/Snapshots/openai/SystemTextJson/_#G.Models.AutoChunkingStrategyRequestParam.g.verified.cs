//HintName: G.Models.AutoChunkingStrategyRequestParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
    /// </summary>
    public sealed partial class AutoChunkingStrategyRequestParam
    {
        /// <summary>
        /// Always `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter))]
        public global::G.AutoChunkingStrategyRequestParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoChunkingStrategyRequestParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoChunkingStrategyRequestParam(
            global::G.AutoChunkingStrategyRequestParamType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoChunkingStrategyRequestParam" /> class.
        /// </summary>
        public AutoChunkingStrategyRequestParam()
        {
        }
    }
}