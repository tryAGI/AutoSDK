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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> GetClientVersionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}