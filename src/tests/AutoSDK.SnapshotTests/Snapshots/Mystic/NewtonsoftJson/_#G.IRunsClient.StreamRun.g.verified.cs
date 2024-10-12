//HintName: G.IRunsClient.StreamRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Stream Run<br/>
        /// Submit a new streaming run request, where the run output is streamed as<br/>
        /// it becomes available, rather than waiting for all the data to be<br/>
        /// generated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StreamRunAsync(
            global::G.RunCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stream Run<br/>
        /// Submit a new streaming run request, where the run output is streamed as<br/>
        /// it becomes available, rather than waiting for all the data to be<br/>
        /// generated.
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
        global::System.Threading.Tasks.Task<string> StreamRunAsync(
            string pipeline,
            global::System.Collections.Generic.IList<global::G.RunInput> inputs,
            bool? asyncRun = false,
            bool? waitForResources = default,
            string? runId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}