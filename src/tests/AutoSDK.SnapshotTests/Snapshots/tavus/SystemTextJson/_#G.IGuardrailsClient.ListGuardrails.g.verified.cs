//HintName: G.IGuardrailsClient.ListGuardrails.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List Guardrails<br/>
        /// Returns a list of all guardrails.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListGuardrailsResponse> ListGuardrailsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}