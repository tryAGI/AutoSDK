//HintName: G.ISecurityClient.GetSuperUserIds.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetSuperUserIds<br/>
        /// GetSuperUserIds
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetSuperUserIdsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}