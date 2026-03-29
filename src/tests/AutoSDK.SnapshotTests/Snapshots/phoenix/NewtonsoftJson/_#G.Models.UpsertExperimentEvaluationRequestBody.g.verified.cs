//HintName: G.Models.UpsertExperimentEvaluationRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertExperimentEvaluationRequestBody
    {
        /// <summary>
        /// The ID of the experiment run being evaluated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentRunId { get; set; } = default!;

        /// <summary>
        /// The name of the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The kind of annotator used for the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotator_kind", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpsertExperimentEvaluationRequestBodyAnnotatorKind AnnotatorKind { get; set; } = default!;

        /// <summary>
        /// The start time of the evaluation in ISO format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// The end time of the evaluation in ISO format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// The result of the evaluation. Either result or error must be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.ExperimentEvaluationResult? Result { get; set; }

        /// <summary>
        /// Error message if the evaluation encountered an error. Either result or error must be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Metadata for the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Optional trace ID for tracking
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertExperimentEvaluationRequestBody" /> class.
        /// </summary>
        /// <param name="experimentRunId">
        /// The ID of the experiment run being evaluated
        /// </param>
        /// <param name="name">
        /// The name of the evaluation
        /// </param>
        /// <param name="annotatorKind">
        /// The kind of annotator used for the evaluation
        /// </param>
        /// <param name="startTime">
        /// The start time of the evaluation in ISO format
        /// </param>
        /// <param name="endTime">
        /// The end time of the evaluation in ISO format
        /// </param>
        /// <param name="result">
        /// The result of the evaluation. Either result or error must be provided.
        /// </param>
        /// <param name="error">
        /// Error message if the evaluation encountered an error. Either result or error must be provided.
        /// </param>
        /// <param name="metadata">
        /// Metadata for the evaluation
        /// </param>
        /// <param name="traceId">
        /// Optional trace ID for tracking
        /// </param>
        public UpsertExperimentEvaluationRequestBody(
            string experimentRunId,
            string name,
            global::G.UpsertExperimentEvaluationRequestBodyAnnotatorKind annotatorKind,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::G.ExperimentEvaluationResult? result,
            string? error,
            object? metadata,
            string? traceId)
        {
            this.ExperimentRunId = experimentRunId ?? throw new global::System.ArgumentNullException(nameof(experimentRunId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AnnotatorKind = annotatorKind;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Result = result;
            this.Error = error;
            this.Metadata = metadata;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertExperimentEvaluationRequestBody" /> class.
        /// </summary>
        public UpsertExperimentEvaluationRequestBody()
        {
        }
    }
}