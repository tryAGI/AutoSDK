//HintName: G.ISecurityClient.SecurityGetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetVersion.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SecurityGetVersionAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}