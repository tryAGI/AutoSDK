//HintName: G.Models.ResponseEngineRetellLm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseEngineRetellLm
    {
        /// <summary>
        /// type of the Response Engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseEngineRetellLmTypeJsonConverter))]
        public global::G.ResponseEngineRetellLmType Type { get; set; }

        /// <summary>
        /// id of the Retell LLM Response Engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmId { get; set; }

        /// <summary>
        /// Version of the Retell LLM Response Engine.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineRetellLm" /> class.
        /// </summary>
        /// <param name="llmId">
        /// id of the Retell LLM Response Engine.
        /// </param>
        /// <param name="type">
        /// type of the Response Engine.
        /// </param>
        /// <param name="version">
        /// Version of the Retell LLM Response Engine.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseEngineRetellLm(
            string llmId,
            global::G.ResponseEngineRetellLmType type,
            double? version)
        {
            this.Type = type;
            this.LlmId = llmId ?? throw new global::System.ArgumentNullException(nameof(llmId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineRetellLm" /> class.
        /// </summary>
        public ResponseEngineRetellLm()
        {
        }
    }
}