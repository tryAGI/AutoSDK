//HintName: G.IPrompt2025Client.UpdatePrompt2025.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultIdStringString> UpdatePrompt2025Async(

            global::G.UpdatePrompt2025Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptBody">
        /// Simplified interface for the OpenAI Chat request format
        /// </param>
        /// <param name="commitMessage"></param>
        /// <param name="environment"></param>
        /// <param name="newMajorVersion"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultIdStringString> UpdatePrompt2025Async(
            global::G.OpenAIChatRequest promptBody,
            string commitMessage,
            bool newMajorVersion,
            string promptVersionId,
            string promptId,
            string? environment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}