//HintName: G.ICorporaClient.CorporaPartialUpdate.g.cs
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
        global::System.Threading.Tasks.Task<global::G.UltravoxV1Corpus> CorporaPartialUpdateAsync(
            global::System.Guid corpusId,
            global::G.UltravoxV1Corpus request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="requestCorpusId">
        /// The unique ID of this corpus.
        /// </param>
        /// <param name="created">
        /// When this corpus was created.
        /// </param>
        /// <param name="name">
        /// The name of this corpus.
        /// </param>
        /// <param name="description">
        /// A description of this corpus.
        /// </param>
        /// <param name="stats">
        /// The current stats for this corpus.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UltravoxV1Corpus> CorporaPartialUpdateAsync(
            global::System.Guid corpusId,
            string? requestCorpusId = default,
            global::System.DateTime? created = default,
            string? name = default,
            string? description = default,
            global::G.UltravoxV1CorpusStats? stats = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}