//HintName: G.IOptimizationsClient.UpdateOptimizationsById.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Update optimization by id<br/>
        /// Update optimization by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateOptimizationsByIdAsync(
            global::System.Guid id,

            global::G.OptimizationUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update optimization by id<br/>
        /// Update optimization by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateOptimizationsByIdAsync(
            global::System.Guid id,
            string? name = default,
            global::G.OptimizationUpdateStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}