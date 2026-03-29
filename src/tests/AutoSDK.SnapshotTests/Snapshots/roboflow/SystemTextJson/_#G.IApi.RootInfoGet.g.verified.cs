//HintName: G.IApi.RootInfoGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Info<br/>
        /// Get the server name and version number
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServerVersionInfo> RootInfoGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}