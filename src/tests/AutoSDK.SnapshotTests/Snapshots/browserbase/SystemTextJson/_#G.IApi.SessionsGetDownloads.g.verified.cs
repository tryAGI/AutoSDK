//HintName: G.IApi.SessionsGetDownloads.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Session Downloads
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SessionsGetDownloadsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}