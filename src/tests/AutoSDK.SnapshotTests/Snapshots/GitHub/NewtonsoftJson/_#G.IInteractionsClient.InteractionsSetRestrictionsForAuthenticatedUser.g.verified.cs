//HintName: G.IInteractionsClient.InteractionsSetRestrictionsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Set interaction restrictions for your public repositories<br/>
        /// Temporarily restricts which type of GitHub user can interact with your public repositories. Setting the interaction limit at the user level will overwrite any interaction limits that are set for individual repositories owned by the user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InteractionLimitResponse> InteractionsSetRestrictionsForAuthenticatedUserAsync(
            global::G.InteractionLimit request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set interaction restrictions for your public repositories<br/>
        /// Temporarily restricts which type of GitHub user can interact with your public repositories. Setting the interaction limit at the user level will overwrite any interaction limits that are set for individual repositories owned by the user.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::G.InteractionLimitResponse> InteractionsSetRestrictionsForAuthenticatedUserAsync(
            global::G.InteractionGroup limit,
            global::G.InteractionExpiry? expiry = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}