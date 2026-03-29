//HintName: G.IPromptClient.GetPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptResultString> GetPromptAsync(
            string promptId,

            global::G.PromptQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptResultString> GetPromptAsync(
            string promptId,
            global::G.PromptQueryParamsTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}