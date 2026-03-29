//HintName: G.IExperimentsClient.CreateExperimentRun.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create run for an experiment
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateExperimentRunResponseBody> CreateExperimentRunAsync(
            string experimentId,

            global::G.CreateExperimentRunRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create run for an experiment
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="datasetExampleId">
        /// The ID of the dataset example used in the experiment run
        /// </param>
        /// <param name="output">
        /// The output of the experiment task
        /// </param>
        /// <param name="repetitionNumber">
        /// The repetition number of the experiment run
        /// </param>
        /// <param name="startTime">
        /// The start time of the experiment run
        /// </param>
        /// <param name="endTime">
        /// The end time of the experiment run
        /// </param>
        /// <param name="traceId">
        /// The ID of the corresponding trace (if one exists)
        /// </param>
        /// <param name="error">
        /// Optional error message if the experiment run encountered an error
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateExperimentRunResponseBody> CreateExperimentRunAsync(
            string experimentId,
            string datasetExampleId,
            object output,
            int repetitionNumber,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string? traceId = default,
            string? error = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}