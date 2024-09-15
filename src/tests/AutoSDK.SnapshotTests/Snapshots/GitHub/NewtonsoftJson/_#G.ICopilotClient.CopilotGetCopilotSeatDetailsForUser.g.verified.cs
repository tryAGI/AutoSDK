//HintName: G.ICopilotClient.CopilotGetCopilotSeatDetailsForUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot seat assignment details for a user<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// Gets the GitHub Copilot seat assignment details for a member of an organization who currently has access to GitHub Copilot.<br/>
        /// Organization owners can view GitHub Copilot seat assignment details for members in their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CopilotSeatDetails> CopilotGetCopilotSeatDetailsForUserAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}