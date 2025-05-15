//HintName: G.IApi.DeployUpdateDeployDeployIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployStatusOut> DeployUpdateDeployDeployIdPutAsync(
            string deployId,
            global::G.DeployLLMUpdateIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="settings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployStatusOut> DeployUpdateDeployDeployIdPutAsync(
            string deployId,
            global::G.ScaleSettings settings,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}