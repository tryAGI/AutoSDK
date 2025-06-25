//HintName: G.IOrgsClient.OrgsUpdatePatAccess.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update the access a fine-grained personal access token has to organization resources<br/>
        /// Updates the access an organization member has to organization resources via a fine-grained personal access token. Limited to revoking the token's existing access. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsUpdatePatAccessAsync(
            string org,
            int patId,
            global::G.OrgsUpdatePatAccessRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the access a fine-grained personal access token has to organization resources<br/>
        /// Updates the access an organization member has to organization resources via a fine-grained personal access token. Limited to revoking the token's existing access. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patId"></param>
        /// <param name="action">
        /// Action to apply to the fine-grained personal access token.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task OrgsUpdatePatAccessAsync(
            string org,
            int patId,
            global::G.OrgsUpdatePatAccessRequestAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}