//HintName: G.ISecurityClient.GetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetVersion<br/>
        /// GetVersion
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetVersionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}