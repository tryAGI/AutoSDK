//HintName: G.IProjectClient.CheckEncryptedData.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// CheckEncryptedData<br/>
        /// CheckEncryptedData
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CheckEncryptedDataAsync(

            global::G.CheckEncryptedDataRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// CheckEncryptedData<br/>
        /// CheckEncryptedData
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CheckEncryptedDataAsync(
            global::System.Guid projectId,
            string encryptedSymKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}