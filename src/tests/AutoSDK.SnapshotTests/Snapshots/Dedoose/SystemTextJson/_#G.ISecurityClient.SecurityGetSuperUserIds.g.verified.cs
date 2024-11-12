//HintName: G.ISecurityClient.SecurityGetSuperUserIds.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetSuperUserIds.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> SecurityGetSuperUserIdsAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}