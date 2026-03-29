//HintName: G.ISubpackageGuardrailsClient.ListGuardrailKeyAssignments.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// List key assignments for a guardrail<br/>
        /// List all API key assignments for a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsListGuardrailKeyAssignmentsResponse200> ListGuardrailKeyAssignmentsAsync(
            global::System.Guid id,
            string? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}