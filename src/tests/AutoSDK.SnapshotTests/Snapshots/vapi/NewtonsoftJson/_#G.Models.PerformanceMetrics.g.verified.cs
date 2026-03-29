//HintName: G.Models.PerformanceMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformanceMetrics
    {
        /// <summary>
        /// These are the individual latencies for each turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turnLatencies")]
        public global::System.Collections.Generic.IList<global::G.TurnLatency>? TurnLatencies { get; set; }

        /// <summary>
        /// This is the average latency for the model to output the first token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelLatencyAverage")]
        public double? ModelLatencyAverage { get; set; }

        /// <summary>
        /// This is the average latency for the text to speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceLatencyAverage")]
        public double? VoiceLatencyAverage { get; set; }

        /// <summary>
        /// This is the average latency for the transcriber.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriberLatencyAverage")]
        public double? TranscriberLatencyAverage { get; set; }

        /// <summary>
        /// This is the average latency for the endpointing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpointingLatencyAverage")]
        public double? EndpointingLatencyAverage { get; set; }

        /// <summary>
        /// This is the average latency for complete turns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turnLatencyAverage")]
        public double? TurnLatencyAverage { get; set; }

        /// <summary>
        /// This is the average latency for packets received from the transport provider in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fromTransportLatencyAverage")]
        public double? FromTransportLatencyAverage { get; set; }

        /// <summary>
        /// This is the average latency for packets sent to the transport provider in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toTransportLatencyAverage")]
        public double? ToTransportLatencyAverage { get; set; }

        /// <summary>
        /// This is the number of times the user was interrupted by the assistant during the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numUserInterrupted")]
        public double? NumUserInterrupted { get; set; }

        /// <summary>
        /// This is the number of times the assistant was interrupted by the user during the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numAssistantInterrupted")]
        public double? NumAssistantInterrupted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceMetrics" /> class.
        /// </summary>
        /// <param name="turnLatencies">
        /// These are the individual latencies for each turn.
        /// </param>
        /// <param name="modelLatencyAverage">
        /// This is the average latency for the model to output the first token.
        /// </param>
        /// <param name="voiceLatencyAverage">
        /// This is the average latency for the text to speech.
        /// </param>
        /// <param name="transcriberLatencyAverage">
        /// This is the average latency for the transcriber.
        /// </param>
        /// <param name="endpointingLatencyAverage">
        /// This is the average latency for the endpointing.
        /// </param>
        /// <param name="turnLatencyAverage">
        /// This is the average latency for complete turns.
        /// </param>
        /// <param name="fromTransportLatencyAverage">
        /// This is the average latency for packets received from the transport provider in milliseconds.
        /// </param>
        /// <param name="toTransportLatencyAverage">
        /// This is the average latency for packets sent to the transport provider in milliseconds.
        /// </param>
        /// <param name="numUserInterrupted">
        /// This is the number of times the user was interrupted by the assistant during the call.
        /// </param>
        /// <param name="numAssistantInterrupted">
        /// This is the number of times the assistant was interrupted by the user during the call.
        /// </param>
        public PerformanceMetrics(
            global::System.Collections.Generic.IList<global::G.TurnLatency>? turnLatencies,
            double? modelLatencyAverage,
            double? voiceLatencyAverage,
            double? transcriberLatencyAverage,
            double? endpointingLatencyAverage,
            double? turnLatencyAverage,
            double? fromTransportLatencyAverage,
            double? toTransportLatencyAverage,
            double? numUserInterrupted,
            double? numAssistantInterrupted)
        {
            this.TurnLatencies = turnLatencies;
            this.ModelLatencyAverage = modelLatencyAverage;
            this.VoiceLatencyAverage = voiceLatencyAverage;
            this.TranscriberLatencyAverage = transcriberLatencyAverage;
            this.EndpointingLatencyAverage = endpointingLatencyAverage;
            this.TurnLatencyAverage = turnLatencyAverage;
            this.FromTransportLatencyAverage = fromTransportLatencyAverage;
            this.ToTransportLatencyAverage = toTransportLatencyAverage;
            this.NumUserInterrupted = numUserInterrupted;
            this.NumAssistantInterrupted = numAssistantInterrupted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceMetrics" /> class.
        /// </summary>
        public PerformanceMetrics()
        {
        }
    }
}