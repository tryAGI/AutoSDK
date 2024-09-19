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
        /// <param name="userId"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetGenerationsByUserIdResponse> GetGenerationsByUserIdAsync(
            string userId,
            int? offset = 0,
            int? limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}