//HintName: G.ICorporaClient.CorporaSourcesCreate.g.cs
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
        global::System.Threading.Tasks.Task<global::G.UltravoxV1CorpusSource> CorporaSourcesCreateAsync(
            global::System.Guid corpusId,
            global::G.UltravoxV1CorpusSource request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="requestCorpusId">
        /// The id of this source's corpus.
        /// </param>
        /// <param name="sourceId">
        /// The unique ID of this source.
        /// </param>
        /// <param name="created">
        /// When this source was created.
        /// </param>
        /// <param name="name">
        /// The name of this source.
        /// </param>
        /// <param name="description">
        /// A description of this source.
        /// </param>
        /// <param name="stats">
        /// The current stats for this source.
        /// </param>
        /// <param name="loadSpec">
        /// DEPRECATED. Prefer setting crawl instead. If either crawl or upload is set, this field will be ignored.
        /// </param>
        /// <param name="crawl">
        /// Allows loading documents by crawling the web.
        /// </param>
        /// <param name="upload">
        /// Allows loading from a uploaded document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UltravoxV1CorpusSource> CorporaSourcesCreateAsync(
            global::System.Guid corpusId,
            string? requestCorpusId = default,
            string? sourceId = default,
            global::System.DateTime? created = default,
            string? name = default,
            string? description = default,
            global::G.UltravoxV1SourceStats? stats = default,
            global::G.UltravoxV1CrawlSpec? loadSpec = default,
            global::G.UltravoxV1CrawlSpec? crawl = default,
            global::G.UltravoxV1UploadSpec? upload = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}