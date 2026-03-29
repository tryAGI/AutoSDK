//HintName: G.IServiceClient.ServerInfoServerInfoGet.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Server Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServerInfoRes> ServerInfoServerInfoGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}