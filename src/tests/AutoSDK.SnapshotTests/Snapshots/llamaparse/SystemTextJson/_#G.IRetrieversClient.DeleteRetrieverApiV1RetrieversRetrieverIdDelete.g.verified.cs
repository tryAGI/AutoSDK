//HintName: G.IRetrieversClient.DeleteRetrieverApiV1RetrieversRetrieverIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Delete Retriever<br/>
        /// Delete a Retriever by ID.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRetrieverApiV1RetrieversRetrieverIdDeleteAsync(
            global::System.Guid retrieverId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}