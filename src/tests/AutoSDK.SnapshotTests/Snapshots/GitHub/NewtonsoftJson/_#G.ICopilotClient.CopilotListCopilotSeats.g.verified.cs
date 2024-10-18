//HintName: G.ICopilotClient.CopilotListCopilotSeats.g.cs
#nullable enable

namespace G
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// List all Copilot seat assignments for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// Lists all active Copilot seats for an organization with a Copilot Business or Copilot Enterprise subscription.<br/>
        /// Only organization owners can view assigned seats.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:org` scopes to use this endpoint.
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
            int? page = 1,
            int? perPage = 50,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}