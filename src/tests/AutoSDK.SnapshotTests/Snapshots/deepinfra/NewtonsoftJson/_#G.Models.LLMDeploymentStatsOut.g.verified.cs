//HintName: G.Models.LLMDeploymentStatsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMDeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int Requests { get; set; } = default!;

        /// <summary>
        /// number of input tokens generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// number of output tokens generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// average millisecond time to first token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_ttft_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgTtftMs { get; set; } = default!;

        /// <summary>
        /// 95th percentile time to first token (estimated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg95_ttft_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double Avg95TtftMs { get; set; } = default!;

        /// <summary>
        /// average millisecond time per token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_tpt_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgTptMs { get; set; } = default!;

        /// <summary>
        /// 95th percentile time per token (estimated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg95_tpt_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double Avg95TptMs { get; set; } = default!;

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_amount_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalAmountCents { get; set; } = default!;

        /// <summary>
        /// number of errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public int Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
        /// <param name="inputTokens">
        /// number of input tokens generated
        /// </param>
        /// <param name="outputTokens">
        /// number of output tokens generated
        /// </param>
        /// <param name="avgTtftMs">
        /// average millisecond time to first token
        /// </param>
        /// <param name="avg95TtftMs">
        /// 95th percentile time to first token (estimated)
        /// </param>
        /// <param name="avgTptMs">
        /// average millisecond time per token
        /// </param>
        /// <param name="avg95TptMs">
        /// 95th percentile time per token (estimated)
        /// </param>
        /// <param name="totalAmountCents">
        /// total number of cents spent
        /// </param>
        /// <param name="errors">
        /// number of errors
        /// </param>
        public LLMDeploymentStatsOut(
            int requests,
            int inputTokens,
            int outputTokens,
            double avgTtftMs,
            double avg95TtftMs,
            double avgTptMs,
            double avg95TptMs,
            int totalAmountCents,
            int errors)
        {
            this.Requests = requests;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.AvgTtftMs = avgTtftMs;
            this.Avg95TtftMs = avg95TtftMs;
            this.AvgTptMs = avgTptMs;
            this.Avg95TptMs = avg95TptMs;
            this.TotalAmountCents = totalAmountCents;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeploymentStatsOut" /> class.
        /// </summary>
        public LLMDeploymentStatsOut()
        {
        }
    }
}