//HintName: G.IGuardrailsClient.CreateGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Create a new guardrail<br/>
        /// Creates a new guardrail with specified checks and actions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateGuardrailResponse> CreateGuardrailAsync(

            global::G.CreateGuardrailRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new guardrail<br/>
        /// Creates a new guardrail with specified checks and actions
        /// </summary>
        /// <param name="name">
        /// Name of the guardrail<br/>
        /// Example: Content Safety Check
        /// </param>
        /// <param name="workspaceId">
        /// Workspace UUID (required if organisation_id not provided and not using API key)
        /// </param>
        /// <param name="organisationId">
        /// Organisation UUID (required if workspace_id not provided and not using API key)
        /// </param>
        /// <param name="checks">
        /// Array of guardrail checks to apply
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateGuardrailResponse> CreateGuardrailAsync(
            string name,
            global::System.Collections.Generic.IList<global::G.GuardrailCheck> checks,
            global::G.GuardrailActions actions,
            global::System.Guid? workspaceId = default,
            global::System.Guid? organisationId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}