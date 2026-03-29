//HintName: G.Models.TurnLatency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurnLatency
    {
        /// <summary>
        /// This is the model latency for the first token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelLatency")]
        public double? ModelLatency { get; set; }

        /// <summary>
        /// This is the voice latency from the model output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceLatency")]
        public double? VoiceLatency { get; set; }

        /// <summary>
        /// This is the transcriber latency from the user speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriberLatency")]
        public double? TranscriberLatency { get; set; }

        /// <summary>
        /// This is the endpointing latency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpointingLatency")]
        public double? EndpointingLatency { get; set; }

        /// <summary>
        /// This is the latency for the whole turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turnLatency")]
        public double? TurnLatency1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnLatency" /> class.
        /// </summary>
        /// <param name="modelLatency">
        /// This is the model latency for the first token.
        /// </param>
        /// <param name="voiceLatency">
        /// This is the voice latency from the model output.
        /// </param>
        /// <param name="transcriberLatency">
        /// This is the transcriber latency from the user speech.
        /// </param>
        /// <param name="endpointingLatency">
        /// This is the endpointing latency.
        /// </param>
        /// <param name="turnLatency1">
        /// This is the latency for the whole turn.
        /// </param>
        public TurnLatency(
            double? modelLatency,
            double? voiceLatency,
            double? transcriberLatency,
            double? endpointingLatency,
            double? turnLatency1)
        {
            this.ModelLatency = modelLatency;
            this.VoiceLatency = voiceLatency;
            this.TranscriberLatency = transcriberLatency;
            this.EndpointingLatency = endpointingLatency;
            this.TurnLatency1 = turnLatency1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnLatency" /> class.
        /// </summary>
        public TurnLatency()
        {
        }
    }
}