//HintName: G.IWelcomeWizardClient.SubmitWelcomeWizard.g.cs
#nullable enable

namespace G
{
    public partial interface IWelcomeWizardClient
    {
        /// <summary>
        /// Submit welcome wizard<br/>
        /// Submit welcome wizard with user information
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SubmitWelcomeWizardAsync(

            global::G.WelcomeWizardSubmission request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit welcome wizard<br/>
        /// Submit welcome wizard with user information
        /// </summary>
        /// <param name="role">
        /// Optional user role
        /// </param>
        /// <param name="integrations">
        /// List of integrations the user selected
        /// </param>
        /// <param name="email">
        /// Optional user email
        /// </param>
        /// <param name="joinBetaProgram">
        /// Whether user wants to join beta programs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SubmitWelcomeWizardAsync(
            string? role = default,
            global::System.Collections.Generic.IList<string>? integrations = default,
            string? email = default,
            bool? joinBetaProgram = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}