//HintName: G.ISecurityClient.GetAllAccessLists.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetAllAccessLists<br/>
        /// GetAllAccessLists
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AccessList>> GetAllAccessListsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}