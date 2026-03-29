//HintName: G.ISubpackageGuardrailsClient.DeleteGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Delete a guardrail<br/>
        /// Delete an existing guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardrailsDeleteGuardrailResponse200> DeleteGuardrailAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}