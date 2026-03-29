//HintName: G.IExperimentsClient.DeleteExperimentsById.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Delete experiments by id<br/>
        /// Delete experiments by id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentsByIdAsync(

            global::G.DeleteIdsHolder request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete experiments by id<br/>
        /// Delete experiments by id
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentsByIdAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}