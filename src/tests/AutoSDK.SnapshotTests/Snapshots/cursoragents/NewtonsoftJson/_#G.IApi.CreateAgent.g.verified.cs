//HintName: G.IApi.CreateAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Launch an agent<br/>
        /// Start a new cloud agent to work on your repository
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAgentResponse> CreateAgentAsync(

            global::G.CreateAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Launch an agent<br/>
        /// Start a new cloud agent to work on your repository
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model">
        /// Set to an explicit model ID for launch requests, or use "default" to use the configured default model. When omitted, Cursor resolves your user default model, then your team default model, then a system default.<br/>
        /// Example: claude-4-sonnet
        /// </param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="webhook"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAgentResponse> CreateAgentAsync(
            global::G.CreateAgentRequestPrompt prompt,
            global::G.CreateAgentRequestSource source,
            string? model = default,
            global::G.CreateAgentRequestTarget? target = default,
            global::G.CreateAgentRequestWebhook? webhook = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}