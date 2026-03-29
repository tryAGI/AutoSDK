//HintName: G.Models.WorkflowInferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowInferenceResponse
    {
        /// <summary>
        /// Dictionary with keys defined in workflow output and serialised values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Outputs { get; set; }

        /// <summary>
        /// Profiler events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiler_trace")]
        public global::System.Collections.Generic.IList<object>? ProfilerTrace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInferenceResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Dictionary with keys defined in workflow output and serialised values
        /// </param>
        /// <param name="profilerTrace">
        /// Profiler events
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowInferenceResponse(
            global::System.Collections.Generic.IList<object> outputs,
            global::System.Collections.Generic.IList<object>? profilerTrace)
        {
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.ProfilerTrace = profilerTrace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInferenceResponse" /> class.
        /// </summary>
        public WorkflowInferenceResponse()
        {
        }
    }
}