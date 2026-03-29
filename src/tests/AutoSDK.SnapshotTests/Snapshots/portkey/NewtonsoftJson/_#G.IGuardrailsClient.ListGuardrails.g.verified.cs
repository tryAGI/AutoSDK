//HintName: G.IGuardrailsClient.ListGuardrails.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List guardrails<br/>
        /// Retrieves a paginated list of guardrails for the specified workspace or organisation
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="organisationId"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListGuardrailsResponse> ListGuardrailsAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? organisationId = default,
            int? pageSize = default,
            int? currentPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}