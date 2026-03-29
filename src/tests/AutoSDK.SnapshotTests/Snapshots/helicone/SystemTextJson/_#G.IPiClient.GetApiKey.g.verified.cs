//HintName: G.IPiClient.GetApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IPiClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultApiKeyStringString> GetApiKeyAsync(

            global::G.GetApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionUUID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultApiKeyStringString> GetApiKeyAsync(
            string sessionUUID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}