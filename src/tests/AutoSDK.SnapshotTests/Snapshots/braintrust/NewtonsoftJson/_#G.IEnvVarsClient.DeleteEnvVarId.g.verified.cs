//HintName: G.IEnvVarsClient.DeleteEnvVarId.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Delete env_var<br/>
        /// Delete an env_var object by its id
        /// </summary>
        /// <param name="envVarId">
        /// EnvVar id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvVar> DeleteEnvVarIdAsync(
            global::System.Guid envVarId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}