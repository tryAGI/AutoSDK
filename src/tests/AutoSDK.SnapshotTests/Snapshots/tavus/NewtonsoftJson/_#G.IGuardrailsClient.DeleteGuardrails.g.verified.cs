//HintName: G.IGuardrailsClient.DeleteGuardrails.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Delete Guardrails<br/>
        /// Deletes a single set of guardrails.
        /// </summary>
        /// <param name="guardrailsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteGuardrailsAsync(
            string guardrailsId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}