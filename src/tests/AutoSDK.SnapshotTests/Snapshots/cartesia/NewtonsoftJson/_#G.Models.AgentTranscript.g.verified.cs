//HintName: G.Models.AgentTranscript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTranscript
    {
        /// <summary>
        /// The role of the participant in the conversation. Roles are `user`, `assistant`, or `system`. `assistant` is the agent. `system` is used to indicate logs during the conversation such as `log_event` or `log_metric`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The text content of the transcript. This is the text that was spoken by the user or the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The chunks of text at a more granular level in the transcript with timestamps relative to the start of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_chunks")]
        public global::System.Collections.Generic.IList<global::G.TextChunk>? TextChunks { get; set; }

        /// <summary>
        /// The start timestamp in seconds relative to the start of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public float StartTimestamp { get; set; } = default!;

        /// <summary>
        /// The end timestamp in seconds relative to the start of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public float EndTimestamp { get; set; } = default!;

        /// <summary>
        /// The reason for why the assistant turn ended. This could be `call_ended`, `interrupted`, or `tts_completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_reason")]
        public string? EndReason { get; set; }

        /// <summary>
        /// The tool calls made during the turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// The VAD buffer time in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vad_buffer_ms")]
        public int? VadBufferMs { get; set; }

        /// <summary>
        /// The time to first byte in seconds from the agent for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts_ttfb")]
        public float? TtsTtfb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_event")]
        public global::G.LogEvent? LogEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_metric")]
        public global::G.LogMetric? LogMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTranscript" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the participant in the conversation. Roles are `user`, `assistant`, or `system`. `assistant` is the agent. `system` is used to indicate logs during the conversation such as `log_event` or `log_metric`.
        /// </param>
        /// <param name="startTimestamp">
        /// The start timestamp in seconds relative to the start of the call.
        /// </param>
        /// <param name="endTimestamp">
        /// The end timestamp in seconds relative to the start of the call.
        /// </param>
        /// <param name="text">
        /// The text content of the transcript. This is the text that was spoken by the user or the agent.
        /// </param>
        /// <param name="textChunks">
        /// The chunks of text at a more granular level in the transcript with timestamps relative to the start of the call.
        /// </param>
        /// <param name="endReason">
        /// The reason for why the assistant turn ended. This could be `call_ended`, `interrupted`, or `tts_completed`.
        /// </param>
        /// <param name="toolCalls">
        /// The tool calls made during the turn.
        /// </param>
        /// <param name="vadBufferMs">
        /// The VAD buffer time in milliseconds.
        /// </param>
        /// <param name="ttsTtfb">
        /// The time to first byte in seconds from the agent for text-to-speech.
        /// </param>
        /// <param name="logEvent"></param>
        /// <param name="logMetric"></param>
        public AgentTranscript(
            string role,
            float startTimestamp,
            float endTimestamp,
            string? text,
            global::System.Collections.Generic.IList<global::G.TextChunk>? textChunks,
            string? endReason,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls,
            int? vadBufferMs,
            float? ttsTtfb,
            global::G.LogEvent? logEvent,
            global::G.LogMetric? logMetric)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Text = text;
            this.TextChunks = textChunks;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.EndReason = endReason;
            this.ToolCalls = toolCalls;
            this.VadBufferMs = vadBufferMs;
            this.TtsTtfb = ttsTtfb;
            this.LogEvent = logEvent;
            this.LogMetric = logMetric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTranscript" /> class.
        /// </summary>
        public AgentTranscript()
        {
        }
    }
}