//HintName: G.ISubpackageGuardrailsClient.BulkAssignMembersToGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Bulk assign members to a guardrail<br/>
        /// Assign multiple organization members to a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkAssignMembersToGuardrailResponse200> BulkAssignMembersToGuardrailAsync(
            global::System.Guid id,

            global::G.BulkAssignMembersToGuardrailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk assign members to a guardrail<br/>
        /// Assign multiple organization members to a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memberUserIds">
        /// Array of member user IDs to assign to the guardrail
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkAssignMembersToGuardrailResponse200> BulkAssignMembersToGuardrailAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> memberUserIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}