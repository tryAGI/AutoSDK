//HintName: G.ISubpackageGuardrailsClient.BulkAssignKeysToGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Bulk assign keys to a guardrail<br/>
        /// Assign multiple API keys to a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkAssignKeysToGuardrailResponse200> BulkAssignKeysToGuardrailAsync(
            global::System.Guid id,

            global::G.BulkAssignKeysToGuardrailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk assign keys to a guardrail<br/>
        /// Assign multiple API keys to a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keyHashes">
        /// Array of API key hashes to assign to the guardrail
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkAssignKeysToGuardrailResponse200> BulkAssignKeysToGuardrailAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> keyHashes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}