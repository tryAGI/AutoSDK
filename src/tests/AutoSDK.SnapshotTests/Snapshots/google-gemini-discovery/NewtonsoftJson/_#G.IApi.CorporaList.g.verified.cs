//HintName: G.IApi.CorporaList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Lists all `Corpora` owned by the user.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCorporaResponse> CorporaListAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}