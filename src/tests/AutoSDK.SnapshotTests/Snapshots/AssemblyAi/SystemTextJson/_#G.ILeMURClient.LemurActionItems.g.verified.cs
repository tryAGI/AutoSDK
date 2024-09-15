//HintName: G.ILeMURClient.LemurActionItems.g.cs
#nullable enable

namespace G
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Extract action items<br/>
        /// Use LeMUR to generate a list of action items from a transcript
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurActionItemsResponse> LemurActionItemsAsync(
            global::G.LemurActionItemsParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Extract action items<br/>
        /// Use LeMUR to generate a list of action items from a transcript
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurActionItemsResponse> LemurActionItemsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}