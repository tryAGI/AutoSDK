//HintName: G.IDocumentsClient.DocumentsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// delete (multiple)<br/>
        /// Delete multiple documents hosted on GroundX<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="documentIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IngestResponse> DocumentsDeleteAsync(
            global::System.Collections.Generic.IList<global::System.Guid> documentIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}