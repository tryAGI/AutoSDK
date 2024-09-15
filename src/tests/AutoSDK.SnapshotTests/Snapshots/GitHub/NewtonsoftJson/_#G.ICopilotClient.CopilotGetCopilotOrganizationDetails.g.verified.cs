//HintName: G.ICopilotClient.CopilotGetCopilotOrganizationDetails.g.cs
#nullable enable

namespace G
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot seat information and settings for an organization<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// Gets information about an organization's Copilot subscription, including seat breakdown<br/>
        /// and code matching policies. To configure these settings, go to your organization's settings on GitHub.com.<br/>
        /// For more information, see "[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-policies-for-copilot-business-in-your-organization)".<br/>
        /// Only organization owners can configure and view details about the organization's Copilot Business subscription.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CopilotOrganizationDetails> CopilotGetCopilotOrganizationDetailsAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}