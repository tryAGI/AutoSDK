//HintName: G.IGuardrailsClient.PatchGuardrails.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Patch Guardrails<br/>
        /// Update guardrails using JSON Patch operations.
        /// </summary>
        /// <param name="guardrailsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Guardrails> PatchGuardrailsAsync(
            string guardrailsId,

            global::System.Collections.Generic.IList<global::G.JsonPatchOperation> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}