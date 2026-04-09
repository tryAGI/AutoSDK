//HintName: G.ICorporaClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Retrieve metadata about a corpus<br/>
        /// The Get Corpus API lets you view metadata about a specific corpus. This is useful for getting information about a corpus without performing a search. This operation does not search the corpus contents. Specify the `corpus_key` to identify the corpus whose metadata you want to retrieve.<br/>
        /// This endpoint helps administrators understand the access control details and monitor the size of corpora to understand information like the amount of quota consumed. You can also use this information for optimizing search and storage utilization.<br/>
        /// For example, you can track the read and write activity of a specific corpus which can help you change your security strategy proactively. You noticed a corpus with an API key with read/write access that is only being used for high volume reads. You may decide to switch to a read-only key.<br/>
        /// In another case, you might respond to a security incident by disabling a specific corpus because of information returned by this endpoint.<br/>
        /// ## Get the number of documents or document parts in a corpus<br/>
        /// Tracking the usage of documents in a corpus enables adminstrators to manage resource allocation efficiently. Monitoring corpus metrics also helps data usage stay within allocated quotas and identify trends in document growth and document segmentation.<br/>
        /// The `limit` object in the response provides comprehensive information about the current usage and limits of a corpus including the number of stored documents, document parts, and character count.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> GetAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}