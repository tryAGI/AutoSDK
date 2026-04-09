//HintName: G.IAiSecretsClient.PutAiSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Create or replace ai_secret<br/>
        /// Create or replace ai_secret. If there is an existing ai_secret with the same name as the one specified in the request, will replace the existing ai_secret with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AISecret> PutAiSecretAsync(

            global::G.CreateAISecret request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace ai_secret<br/>
        /// Create or replace ai_secret. If there is an existing ai_secret with the same name as the one specified in the request, will replace the existing ai_secret with the provided fields
        /// </summary>
        /// <param name="name">
        /// Name of the AI secret
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="secret">
        /// Secret value. If omitted in a PUT request, the existing secret value will be left intact, not replaced with null.
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the AI Secret belongs in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AISecret> PutAiSecretAsync(
            string name,
            string? type = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            string? secret = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}