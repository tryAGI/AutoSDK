//HintName: G.IExperimentsClient.UpsertExperimentEvaluation.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create or update evaluation for an experiment run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpsertExperimentEvaluationResponseBody> UpsertExperimentEvaluationAsync(

            global::G.UpsertExperimentEvaluationRequestBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update evaluation for an experiment run
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpsertExperimentEvaluationResponseBody> UpsertExperimentEvaluationAsync(
            string experimentRunId,
            string name,
            global::G.UpsertExperimentEvaluationRequestBodyAnnotatorKind annotatorKind,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::G.ExperimentEvaluationResult? result = default,
            string? error = default,
            object? metadata = default,
            string? traceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}