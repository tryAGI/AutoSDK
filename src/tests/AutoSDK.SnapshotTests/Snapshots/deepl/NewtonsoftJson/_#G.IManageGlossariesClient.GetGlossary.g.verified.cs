//HintName: G.IManageGlossariesClient.GetGlossary.g.cs
#nullable enable

namespace G
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// Retrieve Glossary Details<br/>
        /// Retrieve meta information for a single glossary, omitting the glossary entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MonolingualGlossary> GetGlossaryAsync(
            string glossaryId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Glossary Details<br/>
        /// Retrieve meta information for a single glossary, omitting the glossary entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.MonolingualGlossary>> GetGlossaryAsResponseAsync(
            string glossaryId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}