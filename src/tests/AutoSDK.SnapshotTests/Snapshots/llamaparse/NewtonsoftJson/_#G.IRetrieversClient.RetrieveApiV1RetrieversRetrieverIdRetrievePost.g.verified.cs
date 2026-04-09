//HintName: G.IRetrieversClient.RetrieveApiV1RetrieversRetrieverIdRetrievePost.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve data using a Retriever.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompositeRetrievalResult> RetrieveApiV1RetrieversRetrieverIdRetrievePostAsync(
            global::System.Guid retrieverId,

            global::G.CompositeRetrievalParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve data using a Retriever.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="mode">
        /// The mode of composite retrieval.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="rerankConfig">
        /// The rerank configuration for composite retrieval.
        /// </param>
        /// <param name="query">
        /// The query to retrieve against.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompositeRetrievalResult> RetrieveApiV1RetrieversRetrieverIdRetrievePostAsync(
            global::System.Guid retrieverId,
            string query,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.CompositeRetrievalMode? mode = default,
            global::G.ReRankConfig? rerankConfig = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}