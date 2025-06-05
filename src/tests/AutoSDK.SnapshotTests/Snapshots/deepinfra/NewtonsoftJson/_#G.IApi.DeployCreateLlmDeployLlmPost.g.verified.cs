//HintName: G.IApi.DeployCreateLlmDeployLlmPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deploy Create Llm
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentOut> DeployCreateLlmDeployLlmPostAsync(
            global::G.DeployLLMIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Create Llm
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="modelName">
        /// model name for deepinfra (username/mode-name format)
        /// </param>
        /// <param name="gpu"></param>
        /// <param name="numGpus">
        /// Number of GPUs you want for this model<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxBatchSize">
        /// Maximum number of concurrent requests<br/>
        /// Default Value: 96
        /// </param>
        /// <param name="hf"></param>
        /// <param name="settings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentOut> DeployCreateLlmDeployLlmPostAsync(
            string modelName,
            global::G.DeployGPUs gpu,
            string? xiApiKey = default,
            int? numGpus = default,
            int? maxBatchSize = default,
            global::G.HFWeights? hf = default,
            global::G.ScaleSettings? settings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}