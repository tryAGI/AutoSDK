//HintName: G.IOptimizationsClient.CancelStudioOptimizations.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Cancel Studio optimizations<br/>
        /// Cancel Studio optimizations by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelStudioOptimizationsAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}