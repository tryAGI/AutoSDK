//HintName: G.ICorporaClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// List corpora<br/>
        /// The List Corpora API lets you retrieve a list of corpora in your account. This endpoint returns a paginated list of corpora objects, which contain basic information about each corpus. The returned corpus objects contain less detail compared to those retrieved the direct corpus retrieval operation.<br/>
        /// You can specify optional parameters to control the pagination and filtering of the results. The limit parameter determines the maximum number of corpora to return, with a default value of 10 and a maximum value of 100.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="corpusId"></param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCorporaResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? filter = default,
            global::System.Collections.Generic.IList<string>? corpusId = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}