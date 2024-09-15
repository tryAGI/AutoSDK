//HintName: G.ICommentsClient.GetComments.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Get Comments
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCommentsResponse> GetCommentsAsync(
            string owner,
            string repo,
            int limit = 20,
            int offset = 0,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}