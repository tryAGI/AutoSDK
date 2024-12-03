//HintName: G.IInteractionsClient.InteractionsSetRestrictionsForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Set interaction restrictions for an organization<br/>
        /// Temporarily restricts interactions to a certain type of GitHub user in any public repository in the given organization. You must be an organization owner to set these restrictions. Setting the interaction limit at the organization level will overwrite any interaction limits that are set for individual repositories owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InteractionLimitResponse> InteractionsSetRestrictionsForOrgAsync(
            string org,
            global::G.InteractionLimit request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set interaction restrictions for an organization<br/>
        /// Temporarily restricts interactions to a certain type of GitHub user in any public repository in the given organization. You must be an organization owner to set these restrictions. Setting the interaction limit at the organization level will overwrite any interaction limits that are set for individual repositories owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="limit">
        /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
        /// Example: collaborators_only
        /// </param>
        /// <param name="expiry">
        /// The duration of the interaction restriction. Default: `one_day`.<br/>
        /// Example: one_month
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InteractionLimitResponse> InteractionsSetRestrictionsForOrgAsync(
            string org,
            global::G.InteractionGroup limit,
            global::G.InteractionExpiry? expiry = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}