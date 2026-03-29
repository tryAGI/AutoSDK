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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_average_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ToolCallAverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_success_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ToolCallSuccessCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ToolCallTotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationAnalysis" /> class.
        /// </summary>
        /// <param name="toolCallAverageLatency"></param>
        /// <param name="toolCallSuccessCount"></param>
        /// <param name="toolCallTotalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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