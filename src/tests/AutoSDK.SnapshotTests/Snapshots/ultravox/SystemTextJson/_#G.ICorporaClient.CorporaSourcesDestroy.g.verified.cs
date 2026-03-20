//HintName: G.ICorporaClient.CorporaSourcesDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="sourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CorporaSourcesDestroyAsync(
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}