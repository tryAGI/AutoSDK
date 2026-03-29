//HintName: G.Models.ResponseEngineCustomLm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseEngineCustomLm
    {
        /// <summary>
        /// type of the Response Engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseEngineCustomLmTypeJsonConverter))]
        public global::G.ResponseEngineCustomLmType Type { get; set; }

        /// <summary>
        /// LLM websocket url of the custom LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_websocket_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmWebsocketUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineCustomLm" /> class.
        /// </summary>
        /// <param name="llmWebsocketUrl">
        /// LLM websocket url of the custom LLM.
        /// </param>
        /// <param name="type">
        /// type of the Response Engine.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseEngineCustomLm(
            string llmWebsocketUrl,
            global::G.ResponseEngineCustomLmType type)
        {
            this.Type = type;
            this.LlmWebsocketUrl = llmWebsocketUrl ?? throw new global::System.ArgumentNullException(nameof(llmWebsocketUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineCustomLm" /> class.
        /// </summary>
        public ResponseEngineCustomLm()
        {
        }
    }
}