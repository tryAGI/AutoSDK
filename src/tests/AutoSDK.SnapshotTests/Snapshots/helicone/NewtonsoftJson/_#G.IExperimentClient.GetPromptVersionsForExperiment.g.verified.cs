//HintName: G.IExperimentClient.GetPromptVersionsForExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentV2PromptVersionArrayString> GetPromptVersionsForExperimentAsync(
            string experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}