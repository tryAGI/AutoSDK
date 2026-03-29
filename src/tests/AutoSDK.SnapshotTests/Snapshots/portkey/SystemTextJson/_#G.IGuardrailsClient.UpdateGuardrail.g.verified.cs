//HintName: G.IGuardrailsClient.UpdateGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Update a guardrail<br/>
        /// Updates an existing guardrail's name, checks, or actions
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateGuardrailResponse> UpdateGuardrailAsync(
            string guardrailId,

            global::G.UpdateGuardrailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Updates an existing guardrail's name, checks, or actions
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="name">
        /// Updated name of the guardrail
        /// </param>
        /// <param name="checks">
        /// Updated array of guardrail checks
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateGuardrailResponse> UpdateGuardrailAsync(
            string guardrailId,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.GuardrailCheck>? checks = default,
            global::G.GuardrailActions? actions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}