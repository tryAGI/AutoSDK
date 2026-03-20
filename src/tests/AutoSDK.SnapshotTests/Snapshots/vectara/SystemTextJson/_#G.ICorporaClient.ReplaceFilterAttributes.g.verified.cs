//HintName: G.ICorporaClient.ReplaceFilterAttributes.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {

        /// <summary>
        /// Replace the filter attributes of a corpus<br/>
        /// Replace the filter attributes of a corpus. This does not happen immediately, as this operation creates a job that completes asynchronously. These new filter attributes will not work until the job completes.<br/>
        /// You can monitor the status of the filter change using the returned job ID. The `corpus_key` uniquely identifies the corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReplaceFilterAttributesResponse> ReplaceFilterAttributesAsync(
            string corpusKey,

            global::G.ReplaceFilterAttributesRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace the filter attributes of a corpus<br/>
        /// Replace the filter attributes of a corpus. This does not happen immediately, as this operation creates a job that completes asynchronously. These new filter attributes will not work until the job completes.<br/>
        /// You can monitor the status of the filter change using the returned job ID. The `corpus_key` uniquely identifies the corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReplaceFilterAttributesResponse> ReplaceFilterAttributesAsync(
            string corpusKey,
            global::System.Collections.Generic.IList<global::G.FilterAttribute> filterAttributes,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}