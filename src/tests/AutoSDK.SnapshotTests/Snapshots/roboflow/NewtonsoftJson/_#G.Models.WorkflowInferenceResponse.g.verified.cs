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
        [global::Newtonsoft.Json.JsonProperty("outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Outputs { get; set; } = default!;

        /// <summary>
        /// Profiler events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profiler_trace")]
        public global::System.Collections.Generic.IList<object>? ProfilerTrace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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