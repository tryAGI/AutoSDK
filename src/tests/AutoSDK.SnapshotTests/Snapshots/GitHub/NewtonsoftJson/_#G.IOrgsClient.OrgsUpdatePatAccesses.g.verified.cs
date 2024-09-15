//HintName: G.IOrgsClient.OrgsUpdatePatAccesses.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update the access to organization resources via fine-grained personal access tokens<br/>
        /// Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> OrgsUpdatePatAccessesAsync(
            string org,
            global::G.OrgsUpdatePatAccessesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the access to organization resources via fine-grained personal access tokens<br/>
        /// Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="action">
        /// Action to apply to the fine-grained personal access token.
        /// </param>
        /// <param name="patIds">
        /// The IDs of the fine-grained personal access tokens.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> OrgsUpdatePatAccessesAsync(
            string org,
            global::System.Collections.Generic.IList<int> patIds,
            global::G.OrgsUpdatePatAccessesRequestAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}