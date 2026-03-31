//HintName: G.IEnvVarsClient.GetEnvVarId.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Get env_var<br/>
        /// Get an env_var object by its id
        /// </summary>
        /// <param name="envVarId">
        /// EnvVar id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvVar> GetEnvVarIdAsync(
            global::System.Guid envVarId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}