//HintName: G.IImageClient.GetGenerationsByUserId.g.cs
#nullable enable

namespace G
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Get generations by user ID<br/>
        /// This endpoint returns all generations by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetGenerationsByUserIdResponse> GetGenerationsByUserIdAsync(
            string userId,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}