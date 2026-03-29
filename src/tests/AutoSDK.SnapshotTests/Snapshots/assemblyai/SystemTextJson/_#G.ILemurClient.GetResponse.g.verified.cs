//HintName: G.ILemurClient.GetResponse.g.cs
#nullable enable

namespace G
{
    public partial interface ILemurClient
    {
        /// <summary>
        /// Retrieve LeMUR response<br/>
        /// Retrieve a LeMUR response that was previously generated.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurResponse> GetResponseAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}