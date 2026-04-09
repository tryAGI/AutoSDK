//HintName: G.IRetrieversClient.UpdateRetrieverApiV1RetrieversRetrieverIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Update Retriever<br/>
        /// Update an existing Retriever.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Retriever> UpdateRetrieverApiV1RetrieversRetrieverIdPutAsync(
            global::System.Guid retrieverId,

            global::G.RetrieverUpdate request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Retriever<br/>
        /// Update an existing Retriever.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// A name for the retriever.
        /// </param>
        /// <param name="pipelines">
        /// The pipelines this retriever uses.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Retriever> UpdateRetrieverApiV1RetrieversRetrieverIdPutAsync(
            global::System.Guid retrieverId,
            string? session = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? pipelines = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}