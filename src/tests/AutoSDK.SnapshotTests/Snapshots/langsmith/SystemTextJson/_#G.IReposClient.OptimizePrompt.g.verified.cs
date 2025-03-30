//HintName: G.IReposClient.OptimizePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Optimize Prompt<br/>
        /// Optimize prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppHubCrudOptimizeOptimizePromptResponse> OptimizePromptAsync(
            global::G.OptimizePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Optimize Prompt<br/>
        /// Optimize prompt
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="metaprompt"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppHubCrudOptimizeOptimizePromptResponse> OptimizePromptAsync(
            string prompt,
            object metaprompt,
            global::System.Collections.Generic.IList<global::G.ExampleRunWithFeedback> examples,
            string? overallFeedback,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}