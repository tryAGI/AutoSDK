//HintName: G.IEnvVarsClient.PatchEnvVarId.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Partially update env_var<br/>
        /// Partially update an env_var object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="envVarId">
        /// EnvVar id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvVar> PatchEnvVarIdAsync(
            global::System.Guid envVarId,

            global::G.PatchEnvVarIdRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update env_var<br/>
        /// Partially update an env_var object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="envVarId">
        /// EnvVar id
        /// </param>
        /// <param name="name">
        /// The name of the environment variable
        /// </param>
        /// <param name="value">
        /// The value of the environment variable. Will be encrypted at rest.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the environment variable when managed via the function secrets API
        /// </param>
        /// <param name="secretType">
        /// Optional classification for the secret (for example, the AI provider name)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvVar> PatchEnvVarIdAsync(
            global::System.Guid envVarId,
            string name,
            string? value = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            string? secretType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}