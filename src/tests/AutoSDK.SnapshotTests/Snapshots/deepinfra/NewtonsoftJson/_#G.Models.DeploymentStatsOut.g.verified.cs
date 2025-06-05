//HintName: G.Models.DeploymentStatsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int Requests { get; set; } = default!;

        /// <summary>
        /// total number of seconds spend in inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTime { get; set; } = default!;

        /// <summary>
        /// total number of tokens generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

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
        /// total number of cents spent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalAmount { get; set; } = default!;

        /// <summary>
        /// average millisecond inference time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgTime { get; set; } = default!;

        /// <summary>
        /// 95th percentile inference time (estimated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg95_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Avg95Time { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
        /// <param name="totalTime">
        /// total number of seconds spend in inference
        /// </param>
        /// <param name="totalTokens">
        /// total number of tokens generated
        /// </param>
        /// <param name="inputTokens">
        /// number of input tokens generated
        /// </param>
        /// <param name="outputTokens">
        /// number of output tokens generated
        /// </param>
        /// <param name="totalAmount">
        /// total number of cents spent
        /// </param>
        /// <param name="avgTime">
        /// average millisecond inference time
        /// </param>
        /// <param name="avg95Time">
        /// 95th percentile inference time (estimated)
        /// </param>
        /// <param name="errors">
        /// number of errors
        /// </param>
        public DeploymentStatsOut(
            int requests,
            int totalTime,
            int totalTokens,
            int inputTokens,
            int outputTokens,
            int totalAmount,
            double avgTime,
            double avg95Time,
            int errors)
        {
            this.Requests = requests;
            this.TotalTime = totalTime;
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalAmount = totalAmount;
            this.AvgTime = avgTime;
            this.Avg95Time = avg95Time;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentStatsOut" /> class.
        /// </summary>
        public DeploymentStatsOut()
        {
        }
    }
}