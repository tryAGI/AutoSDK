//HintName: G.IServiceClient.Root.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Returns information about the running Qdrant instance<br/>
        /// Returns information about the running Qdrant instance like version and commit id
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VersionInfo> RootAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}