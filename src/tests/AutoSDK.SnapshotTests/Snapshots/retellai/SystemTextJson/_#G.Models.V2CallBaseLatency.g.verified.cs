//HintName: G.Models.V2CallBaseLatency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Latency tracking of the call, available after call ends. Not all fields here will be available, as it depends on the type of call and feature used.
    /// </summary>
    public sealed partial class V2CallBaseLatency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e")]
        public global::G.CallLatency? E2e { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::G.CallLatency? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::G.CallLatency? Llm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_websocket_network_rtt")]
        public global::G.CallLatency? LlmWebsocketNetworkRtt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.CallLatency? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public global::G.CallLatency? KnowledgeBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s2s")]
        public global::G.CallLatency? S2s { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBaseLatency" /> class.
        /// </summary>
        /// <param name="e2e"></param>
        /// <param name="asr"></param>
        /// <param name="llm"></param>
        /// <param name="llmWebsocketNetworkRtt"></param>
        /// <param name="tts"></param>
        /// <param name="knowledgeBase"></param>
        /// <param name="s2s"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2CallBaseLatency(
            global::G.CallLatency? e2e,
            global::G.CallLatency? asr,
            global::G.CallLatency? llm,
            global::G.CallLatency? llmWebsocketNetworkRtt,
            global::G.CallLatency? tts,
            global::G.CallLatency? knowledgeBase,
            global::G.CallLatency? s2s)
        {
            this.E2e = e2e;
            this.Asr = asr;
            this.Llm = llm;
            this.LlmWebsocketNetworkRtt = llmWebsocketNetworkRtt;
            this.Tts = tts;
            this.KnowledgeBase = knowledgeBase;
            this.S2s = s2s;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBaseLatency" /> class.
        /// </summary>
        public V2CallBaseLatency()
        {
        }
    }
}