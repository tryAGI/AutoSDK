//HintName: G.IActivityClient.ActivityGetThread.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get a thread<br/>
        /// Gets information about a notification thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Thread> ActivityGetThreadAsync(
            int threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}