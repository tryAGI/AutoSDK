//HintName: G.Models.LatencyMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LatencyMetrics
    {
        /// <summary>
        /// This is the number of conversation turns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turnCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double TurnCount { get; set; } = default!;

        /// <summary>
        /// This is the average total turn latency in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avgTurn")]
        public double? AvgTurn { get; set; }

        /// <summary>
        /// This is the average transcriber latency in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avgTranscriber")]
        public double? AvgTranscriber { get; set; }

        /// <summary>
        /// This is the average LLM/model latency in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avgModel")]
        public double? AvgModel { get; set; }

        /// <summary>
        /// This is the average voice/TTS latency in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avgVoice")]
        public double? AvgVoice { get; set; }

        /// <summary>
        /// This is the average endpointing latency in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avgEndpointing")]
        public double? AvgEndpointing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyMetrics" /> class.
        /// </summary>
        /// <param name="turnCount">
        /// This is the number of conversation turns.
        /// </param>
        /// <param name="avgTurn">
        /// This is the average total turn latency in milliseconds.
        /// </param>
        /// <param name="avgTranscriber">
        /// This is the average transcriber latency in milliseconds.
        /// </param>
        /// <param name="avgModel">
        /// This is the average LLM/model latency in milliseconds.
        /// </param>
        /// <param name="avgVoice">
        /// This is the average voice/TTS latency in milliseconds.
        /// </param>
        /// <param name="avgEndpointing">
        /// This is the average endpointing latency in milliseconds.
        /// </param>
        public LatencyMetrics(
            double turnCount,
            double? avgTurn,
            double? avgTranscriber,
            double? avgModel,
            double? avgVoice,
            double? avgEndpointing)
        {
            this.TurnCount = turnCount;
            this.AvgTurn = avgTurn;
            this.AvgTranscriber = avgTranscriber;
            this.AvgModel = avgModel;
            this.AvgVoice = avgVoice;
            this.AvgEndpointing = avgEndpointing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyMetrics" /> class.
        /// </summary>
        public LatencyMetrics()
        {
        }
    }
}