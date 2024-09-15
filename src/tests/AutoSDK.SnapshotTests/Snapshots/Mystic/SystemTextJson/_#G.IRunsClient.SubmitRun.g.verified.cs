//HintName: G.IRunsClient.SubmitRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Submit Run<br/>
        /// Submits a new run request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClusterRunResult> SubmitRunAsync(
            global::G.RunCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit Run<br/>
        /// Submits a new run request
        /// </summary>
        /// <param name="pipeline"></param>
        /// <param name="inputs"></param>
        /// <param name="asyncRun">
        /// Default Value: false
        /// </param>
        /// <param name="waitForResources"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClusterRunResult> SubmitRunAsync(
            string pipeline,
            global::System.Collections.Generic.IList<global::G.RunInput> inputs,
            bool asyncRun = false,
            bool waitForResources = default,
            string? runId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}