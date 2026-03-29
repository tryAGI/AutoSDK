//HintName: G.ISubpackageGuardrailsClient.ListKeyAssignments.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// List all key assignments<br/>
        /// List all API key guardrail assignments for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsListKeyAssignmentsResponse200> ListKeyAssignmentsAsync(
            string? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}