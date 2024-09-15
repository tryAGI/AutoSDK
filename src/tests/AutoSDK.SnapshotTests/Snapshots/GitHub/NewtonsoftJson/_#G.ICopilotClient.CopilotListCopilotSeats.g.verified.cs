//HintName: G.ICopilotClient.CopilotListCopilotSeats.g.cs
#nullable enable

namespace G
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// List all Copilot seat assignments for an organization<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// Lists all Copilot seat assignments for an organization that are currently being billed (either active or pending cancellation at the start of the next billing cycle).<br/>
        /// Only organization owners can configure and view details about the organization's Copilot Business or Enterprise subscription.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CopilotListCopilotSeatsResponse> CopilotListCopilotSeatsAsync(
            string org,
            int page = 1,
            int perPage = 50,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}