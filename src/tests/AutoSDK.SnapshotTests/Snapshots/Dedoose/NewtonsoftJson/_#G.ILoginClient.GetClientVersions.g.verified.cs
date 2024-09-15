//HintName: G.ILoginClient.GetClientVersions.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Returns client versions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetClientVersionsResponse> GetClientVersionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}