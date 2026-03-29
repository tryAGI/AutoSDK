//HintName: G.ICollectionsClient.GetOptimizations.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Get optimization progress<br/>
        /// Get progress of ongoing and completed optimizations for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="with"></param>
        /// <param name="completedLimit">
        /// Default Value: 16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOptimizationsResponse> GetOptimizationsAsync(
            string collectionName,
            string? with = default,
            int? completedLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}