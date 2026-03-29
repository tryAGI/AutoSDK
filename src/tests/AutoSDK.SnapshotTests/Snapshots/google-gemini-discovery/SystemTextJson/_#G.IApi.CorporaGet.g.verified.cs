//HintName: G.IApi.CorporaGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets information about a specific `Corpus`.
        /// </summary>
        /// <param name="corporaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> CorporaGetAsync(
            string corporaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}