//HintName: G.IPrompt2025Client.CreatePrompt2025.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultPromptCreateResponseString> CreatePrompt2025Async(

            global::G.CreatePrompt2025Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptBody">
        /// Simplified interface for the OpenAI Chat request format
        /// </param>
        /// <param name="tags"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptCreateResponseString> CreatePrompt2025Async(
            global::G.OpenAIChatRequest promptBody,
            global::System.Collections.Generic.IList<string> tags,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}