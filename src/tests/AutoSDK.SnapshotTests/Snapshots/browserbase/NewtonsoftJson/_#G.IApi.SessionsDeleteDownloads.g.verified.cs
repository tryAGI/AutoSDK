//HintName: G.IApi.SessionsDeleteDownloads.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete Session Downloads
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SessionsDeleteDownloadsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}