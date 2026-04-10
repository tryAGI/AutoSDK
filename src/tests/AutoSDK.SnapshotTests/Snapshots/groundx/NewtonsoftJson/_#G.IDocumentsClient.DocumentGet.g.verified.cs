//HintName: G.IDocumentsClient.DocumentGet.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// get<br/>
        /// Look up an existing document by documentId.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentResponse> DocumentGetAsync(
            global::System.Guid documentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}