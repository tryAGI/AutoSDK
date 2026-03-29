//HintName: G.IExperimentsClient.FinishExperiments.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Finish experiments<br/>
        /// Finish experiments and trigger alert events
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task FinishExperimentsAsync(

            global::G.DeleteIdsHolder request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Finish experiments<br/>
        /// Finish experiments and trigger alert events
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task FinishExperimentsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}