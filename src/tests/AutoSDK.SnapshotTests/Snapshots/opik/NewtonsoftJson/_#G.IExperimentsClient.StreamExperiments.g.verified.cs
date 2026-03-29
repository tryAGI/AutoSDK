//HintName: G.IExperimentsClient.StreamExperiments.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Stream experiments<br/>
        /// Stream experiments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamExperimentsAsync(

            global::G.ExperimentStreamRequestPublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream experiments<br/>
        /// Stream experiments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="limit"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="projectName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamExperimentsAsync(
            string name,
            int? limit = default,
            global::System.Guid? lastRetrievedId = default,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}