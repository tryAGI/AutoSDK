//HintName: G.IApi.SessionsList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Sessions
        /// </summary>
        /// <param name="status"></param>
        /// <param name="q"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Session>> SessionsListAsync(
            global::G.SessionsListStatus? status = default,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}