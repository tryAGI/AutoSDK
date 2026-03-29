//HintName: G.ISubpackageGuardrailsClient.BulkUnassignKeysFromGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Bulk unassign keys from a guardrail<br/>
        /// Unassign multiple API keys from a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkUnassignKeysFromGuardrailResponse200> BulkUnassignKeysFromGuardrailAsync(
            global::System.Guid id,

            global::G.BulkUnassignKeysFromGuardrailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk unassign keys from a guardrail<br/>
        /// Unassign multiple API keys from a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keyHashes">
        /// Array of API key hashes to unassign from the guardrail
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsBulkUnassignKeysFromGuardrailResponse200> BulkUnassignKeysFromGuardrailAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> keyHashes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}