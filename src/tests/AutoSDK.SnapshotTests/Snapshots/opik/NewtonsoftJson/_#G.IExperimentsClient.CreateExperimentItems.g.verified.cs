//HintName: G.IExperimentsClient.CreateExperimentItems.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create experiment items<br/>
        /// Create experiment items
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateExperimentItemsAsync(

            global::G.ExperimentItemsBatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment items<br/>
        /// Create experiment items
        /// </summary>
        /// <param name="experimentItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateExperimentItemsAsync(
            global::System.Collections.Generic.IList<global::G.ExperimentItem> experimentItems,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}