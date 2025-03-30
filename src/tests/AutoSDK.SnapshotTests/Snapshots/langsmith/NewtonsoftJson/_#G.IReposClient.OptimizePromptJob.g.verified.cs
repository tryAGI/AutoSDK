//HintName: G.IReposClient.OptimizePromptJob.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Optimize Prompt Job<br/>
        /// Optimize prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppSchemasOptimizePromptResponse> OptimizePromptJobAsync(
            global::G.OptimizePromptJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Optimize Prompt Job<br/>
        /// Optimize prompt
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="promptName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppSchemasOptimizePromptResponse> OptimizePromptJobAsync(
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config,
            string promptName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}