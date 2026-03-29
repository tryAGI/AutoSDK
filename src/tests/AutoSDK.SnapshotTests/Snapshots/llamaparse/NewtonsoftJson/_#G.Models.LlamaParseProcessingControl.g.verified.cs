//HintName: G.Models.LlamaParseProcessingControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job processing controls for timeouts and failure handling.
    /// </summary>
    public sealed partial class LlamaParseProcessingControl
    {
        /// <summary>
        /// Timeout settings for job execution. Increase for large or complex documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeouts")]
        public global::G.LlamaParseTimeouts? Timeouts { get; set; }

        /// <summary>
        /// Quality thresholds that determine when a job should fail vs complete with partial results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_failure_conditions")]
        public global::G.LlamaParseJobFailureConditions? JobFailureConditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseProcessingControl" /> class.
        /// </summary>
        /// <param name="timeouts">
        /// Timeout settings for job execution. Increase for large or complex documents
        /// </param>
        /// <param name="jobFailureConditions">
        /// Quality thresholds that determine when a job should fail vs complete with partial results
        /// </param>
        public LlamaParseProcessingControl(
            global::G.LlamaParseTimeouts? timeouts,
            global::G.LlamaParseJobFailureConditions? jobFailureConditions)
        {
            this.Timeouts = timeouts;
            this.JobFailureConditions = jobFailureConditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseProcessingControl" /> class.
        /// </summary>
        public LlamaParseProcessingControl()
        {
        }
    }
}