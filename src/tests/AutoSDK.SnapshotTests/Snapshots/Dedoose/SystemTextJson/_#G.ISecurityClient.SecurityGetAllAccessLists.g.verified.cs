//HintName: G.ISecurityClient.SecurityGetAllAccessLists.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetAllAccessLists.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AccessList>> SecurityGetAllAccessListsAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}