//HintName: G.ISubpackageGuardrailsClient.BulkUnassignMembersFromGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Bulk unassign members from a guardrail<br/>
        /// Unassign multiple organization members from a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkUnassignMembersFromGuardrailResponse200> BulkUnassignMembersFromGuardrailAsync(
            global::System.Guid id,

            global::G.BulkUnassignMembersFromGuardrailRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk unassign members from a guardrail<br/>
        /// Unassign multiple organization members from a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memberUserIds">
        /// Array of member user IDs to unassign from the guardrail
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkUnassignMembersFromGuardrailResponse200> BulkUnassignMembersFromGuardrailAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> memberUserIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}