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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseEngineCustomLmType Type { get; set; }

        /// <summary>
        /// LLM websocket url of the custom LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_websocket_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LlmWebsocketUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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