//HintName: G.ICodeScanningClient.CodeScanningUpdateAlert.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Update a code scanning alert<br/>
        /// Updates the status of a single code scanning alert.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningAlert> CodeScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::G.CodeScanningUpdateAlertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a code scanning alert<br/>
        /// Updates the status of a single code scanning alert.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningAlert> CodeScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::G.CodeScanningAlertSetState state,
            global::G.CodeScanningAlertDismissedReason? dismissedReason = default,
            string? dismissedComment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}