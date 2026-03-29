//HintName: G.Models.MetricResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricResult
    {
        /// <summary>
        /// The unique identifier for the metric result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The identifier of the metric being measured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metricId", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetricId { get; set; } = default!;

        /// <summary>
        /// The name of the metric being measured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metricName", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetricName { get; set; } = default!;

        /// <summary>
        /// A summary of the transcript of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// The transcript of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public global::System.Collections.Generic.IList<global::G.AgentTranscript>? Transcript { get; set; }

        /// <summary>
        /// The identifier of the agent associated with the metric result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The identifier of the call associated with the metric result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// The identifier of the deployment associated with the metric result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploymentId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentId { get; set; } = default!;

        /// <summary>
        /// The raw result of the metric in a string format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public string Result { get; set; } = default!;

        /// <summary>
        /// The structured JSON result of the metric.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jsonResult")]
        public object? JsonResult { get; set; }

        /// <summary>
        /// The value of the metric result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// The status of an agent metric result. `failed` indicates that the metric result was not computed or parsed properly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentMetricResultStatus Status { get; set; } = default!;

        /// <summary>
        /// The identifier of the run associated with the metric result, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runId")]
        public string? RunId { get; set; }

        /// <summary>
        /// The UTC timestamp when the metric result was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the metric result.
        /// </param>
        /// <param name="metricId">
        /// The identifier of the metric being measured.
        /// </param>
        /// <param name="metricName">
        /// The name of the metric being measured.
        /// </param>
        /// <param name="summary">
        /// A summary of the transcript of the call.
        /// </param>
        /// <param name="agentId">
        /// The identifier of the agent associated with the metric result.
        /// </param>
        /// <param name="callId">
        /// The identifier of the call associated with the metric result.
        /// </param>
        /// <param name="deploymentId">
        /// The identifier of the deployment associated with the metric result.
        /// </param>
        /// <param name="result">
        /// The raw result of the metric in a string format.
        /// </param>
        /// <param name="status">
        /// The status of an agent metric result. `failed` indicates that the metric result was not computed or parsed properly.
        /// </param>
        /// <param name="createdAt">
        /// The UTC timestamp when the metric result was created.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the call.
        /// </param>
        /// <param name="jsonResult">
        /// The structured JSON result of the metric.
        /// </param>
        /// <param name="value">
        /// The value of the metric result.
        /// </param>
        /// <param name="runId">
        /// The identifier of the run associated with the metric result, if applicable.
        /// </param>
        public MetricResult(
            string id,
            string metricId,
            string metricName,
            string summary,
            string agentId,
            string callId,
            string deploymentId,
            string result,
            global::G.AgentMetricResultStatus status,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::G.AgentTranscript>? transcript,
            object? jsonResult,
            object? value,
            string? runId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MetricId = metricId ?? throw new global::System.ArgumentNullException(nameof(metricId));
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Transcript = transcript;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.JsonResult = jsonResult;
            this.Value = value;
            this.Status = status;
            this.RunId = runId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        public MetricResult()
        {
        }
    }
}