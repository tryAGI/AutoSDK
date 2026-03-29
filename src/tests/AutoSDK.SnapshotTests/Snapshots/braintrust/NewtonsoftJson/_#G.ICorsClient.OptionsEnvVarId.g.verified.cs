//HintName: G.ICorsClient.OptionsEnvVarId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/env_var/{env_var_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="envVarId">
        /// EnvVar id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsEnvVarIdAsync(
            global::System.Guid envVarId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}