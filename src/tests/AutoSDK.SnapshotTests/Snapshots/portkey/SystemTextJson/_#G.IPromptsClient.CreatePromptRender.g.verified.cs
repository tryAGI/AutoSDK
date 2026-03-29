//HintName: G.IPromptsClient.CreatePromptRender.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompts Render<br/>
        /// Renders a prompt template with its variable values filled in
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptRenderResponse> CreatePromptRenderAsync(
            string promptId,

            global::G.CreatePromptRenderRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompts Render<br/>
        /// Renders a prompt template with its variable values filled in
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptRenderResponse> CreatePromptRenderAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}