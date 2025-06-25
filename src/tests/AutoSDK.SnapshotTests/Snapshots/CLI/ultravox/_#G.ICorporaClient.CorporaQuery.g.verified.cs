//HintName: G.ICorporaClient.CorporaQuery.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UltravoxV1CorpusQueryResult>> CorporaQueryAsync(
            global::System.Guid corpusId,
            global::G.UltravoxV1QueryCorpusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="query">
        /// The query to run.
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UltravoxV1CorpusQueryResult>> CorporaQueryAsync(
            global::System.Guid corpusId,
            string? query = default,
            int? maxResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}