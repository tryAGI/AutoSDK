//HintName: G.IPrompt2025Client.GetPrompt2025TotalVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionCountsString> GetPrompt2025TotalVersionsAsync(

            global::G.GetPrompt2025TotalVersionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionCountsString> GetPrompt2025TotalVersionsAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}