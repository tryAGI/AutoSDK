//HintName: G.Models.ToolCallInvocationAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallInvocationAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_average_latency", Required = global::Newtonsoft.Json.Required.Always)]
        public double ToolCallAverageLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_success_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double ToolCallSuccessCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double ToolCallTotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationAnalysis" /> class.
        /// </summary>
        /// <param name="toolCallAverageLatency"></param>
        /// <param name="toolCallSuccessCount"></param>
        /// <param name="toolCallTotalCount"></param>
        public ToolCallInvocationAnalysis(
            double toolCallAverageLatency,
            double toolCallSuccessCount,
            double toolCallTotalCount)
        {
            this.ToolCallAverageLatency = toolCallAverageLatency;
            this.ToolCallSuccessCount = toolCallSuccessCount;
            this.ToolCallTotalCount = toolCallTotalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationAnalysis" /> class.
        /// </summary>
        public ToolCallInvocationAnalysis()
        {
        }
    }
}