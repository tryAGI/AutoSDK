//HintName: G.IPromptClient.GetPromptVersions.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultArrayString> GetPromptVersionsAsync(
            string promptId,

            global::G.PromptVersionsQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="filter"></param>
        /// <param name="includeExperimentVersions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultArrayString> GetPromptVersionsAsync(
            string promptId,
            global::G.PromptVersionsFilterNode? filter = default,
            bool? includeExperimentVersions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}