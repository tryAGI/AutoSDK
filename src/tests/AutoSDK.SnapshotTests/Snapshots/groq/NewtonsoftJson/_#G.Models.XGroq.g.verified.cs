//HintName: G.Models.XGroq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groq-specific metadata for streaming responses. Different fields appear in different chunks.
    /// </summary>
    public sealed partial class XGroq
    {
        /// <summary>
        /// A groq request ID which can be used to refer to a specific request to groq support.<br/>
        /// Sent only in the first and final chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The seed used for the request. Sent in the final chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Usage information for the stream. Only sent in the final chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Detailed usage breakdown by model when multiple models are used in the request for compound AI systems. Only sent in the final chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_breakdown")]
        public global::G.ChatCompletionUsageBreakdown? UsageBreakdown { get; set; }

        /// <summary>
        /// An error string indicating why a stream was stopped early.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug")]
        public global::G.DebugData? Debug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroq" /> class.
        /// </summary>
        /// <param name="id">
        /// A groq request ID which can be used to refer to a specific request to groq support.<br/>
        /// Sent only in the first and final chunk.
        /// </param>
        /// <param name="seed">
        /// The seed used for the request. Sent in the final chunk.
        /// </param>
        /// <param name="usage">
        /// Usage information for the stream. Only sent in the final chunk.
        /// </param>
        /// <param name="usageBreakdown">
        /// Detailed usage breakdown by model when multiple models are used in the request for compound AI systems. Only sent in the final chunk.
        /// </param>
        /// <param name="error">
        /// An error string indicating why a stream was stopped early.
        /// </param>
        /// <param name="debug"></param>
        public XGroq(
            string? id,
            int? seed,
            global::G.CompletionUsage? usage,
            global::G.ChatCompletionUsageBreakdown? usageBreakdown,
            string? error,
            global::G.DebugData? debug)
        {
            this.Id = id;
            this.Seed = seed;
            this.Usage = usage;
            this.UsageBreakdown = usageBreakdown;
            this.Error = error;
            this.Debug = debug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroq" /> class.
        /// </summary>
        public XGroq()
        {
        }
    }
}