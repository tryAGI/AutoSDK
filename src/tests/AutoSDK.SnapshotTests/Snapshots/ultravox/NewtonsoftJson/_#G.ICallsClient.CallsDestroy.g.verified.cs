//HintName: G.ICallsClient.CallsDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CallsDestroyAsync(
            global::System.Guid callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}