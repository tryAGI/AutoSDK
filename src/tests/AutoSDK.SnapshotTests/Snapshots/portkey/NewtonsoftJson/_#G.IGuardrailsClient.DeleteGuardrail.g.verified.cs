//HintName: G.IGuardrailsClient.DeleteGuardrail.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Delete a guardrail<br/>
        /// Deletes an existing guardrail
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteGuardrailAsync(
            string guardrailId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}