//HintName: G.IPromptsClient.RemovePromptDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Remove Prompt Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task RemovePromptDeploymentAsync(
            string id,
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}