//HintName: G.ISubpackageGuardrailsClient.ListGuardrailMemberAssignments.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// List member assignments for a guardrail<br/>
        /// List all organization member assignments for a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsListGuardrailMemberAssignmentsResponse200> ListGuardrailMemberAssignmentsAsync(
            global::System.Guid id,
            string? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}