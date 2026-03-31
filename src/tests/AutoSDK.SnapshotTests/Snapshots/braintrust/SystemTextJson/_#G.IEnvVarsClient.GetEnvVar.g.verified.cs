//HintName: G.IEnvVarsClient.GetEnvVar.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// List env_vars<br/>
        /// List out all env_vars. The env_vars are sorted by creation date, with the most recently-created env_vars coming first
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return
        /// </param>
        /// <param name="ids">
        /// Filter search results to a particular set of object IDs. To specify a list of IDs, include the query param multiple times
        /// </param>
        /// <param name="envVarName">
        /// Name of the env_var to search for
        /// </param>
        /// <param name="objectType">
        /// The type of the object the environment variable is scoped for
        /// </param>
        /// <param name="objectId">
        /// The id of the object the environment variable is scoped for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetEnvVarResponse> GetEnvVarAsync(
            int? limit = default,
            global::G.Ids? ids = default,
            string? envVarName = default,
            global::G.EnvVarObjectType? objectType = default,
            global::System.Guid? objectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}