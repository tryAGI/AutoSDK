//HintName: G.IApi.SessionsGetDebug.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Session Live URLs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionLiveUrls> SessionsGetDebugAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}