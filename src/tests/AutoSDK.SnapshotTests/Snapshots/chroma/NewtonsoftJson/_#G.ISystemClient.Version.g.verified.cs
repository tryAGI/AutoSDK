//HintName: G.ISystemClient.Version.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Get version<br/>
        /// Returns the version of the server.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const version = await client.version();
        /// </remarks>
        global::System.Threading.Tasks.Task<string> VersionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}