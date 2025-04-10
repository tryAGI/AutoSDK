//HintName: G.ICorporaClient.CorporaSourcesDocumentsList.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="sourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedultravoxV1CorpusDocumentList> CorporaSourcesDocumentsListAsync(
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            string? cursor = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}