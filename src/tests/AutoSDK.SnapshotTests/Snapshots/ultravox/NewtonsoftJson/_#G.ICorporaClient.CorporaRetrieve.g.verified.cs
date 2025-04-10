//HintName: G.ICorporaClient.CorporaRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UltravoxV1Corpus> CorporaRetrieveAsync(
            global::System.Guid corpusId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}