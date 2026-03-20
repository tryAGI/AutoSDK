//HintName: G.ILeMUR2Client.ActionItems.g.cs
#nullable enable

namespace G
{
    public partial interface ILeMUR2Client
    {
        /// <summary>
        /// Extract action items<br/>
        /// Use LeMUR to generate a list of action items from a transcript
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurActionItemsResponse> ActionItemsAsync(

            global::G.LemurActionItemsParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract action items<br/>
        /// Use LeMUR to generate a list of action items from a transcript
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurActionItemsResponse> ActionItemsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}