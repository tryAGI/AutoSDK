//HintName: G.IAgentClient.Generate.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultChatCompletionOrContentStringReasoningStringCallsAnyString> GenerateAsync(

            global::G.AllOf<global::G.OpenAIChatRequest, global::G.GenerateRequest4> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultChatCompletionOrContentStringReasoningStringCallsAnyString> GenerateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}