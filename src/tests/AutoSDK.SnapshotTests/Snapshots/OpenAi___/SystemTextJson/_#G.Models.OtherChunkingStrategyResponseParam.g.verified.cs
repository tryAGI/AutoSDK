//HintName: G.Models.OtherChunkingStrategyResponseParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
    /// </summary>
    public sealed partial class OtherChunkingStrategyResponseParam
    {
        /// <summary>
        /// Always `other`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter))]
        public global::G.OtherChunkingStrategyResponseParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherChunkingStrategyResponseParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `other`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OtherChunkingStrategyResponseParam(
            global::G.OtherChunkingStrategyResponseParamType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherChunkingStrategyResponseParam" /> class.
        /// </summary>
        public OtherChunkingStrategyResponseParam()
        {
        }
    }
}