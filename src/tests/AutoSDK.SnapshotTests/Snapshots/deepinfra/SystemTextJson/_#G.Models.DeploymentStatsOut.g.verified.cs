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
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// total number of seconds spend in inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTime { get; set; }

        /// <summary>
        /// total number of tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// number of input tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// number of output tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAmount { get; set; }

        /// <summary>
        /// average millisecond inference time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTime { get; set; }

        /// <summary>
        /// 95th percentile inference time (estimated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg95_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Avg95Time { get; set; }

        /// <summary>
        /// number of errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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