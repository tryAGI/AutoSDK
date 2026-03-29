//HintName: G.IEnvVarsClient.PostEnvVar.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Create env_var<br/>
        /// Create a new env_var. If there is an existing env_var with the same name as the one specified in the request, will return the existing env_var unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvVar> PostEnvVarAsync(

            global::G.PostEnvVarRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create env_var<br/>
        /// Create a new env_var. If there is an existing env_var with the same name as the one specified in the request, will return the existing env_var unmodified
        /// </summary>
        /// <param name="objectType">
        /// The type of the object the environment variable is scoped for
        /// </param>
        /// <param name="objectId">
        /// The id of the object the environment variable is scoped for
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvVar> PostEnvVarAsync(
            global::G.PostEnvVarRequestObjectType objectType,
            global::System.Guid objectId,
            string name,
            string? value = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            string? secretType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}