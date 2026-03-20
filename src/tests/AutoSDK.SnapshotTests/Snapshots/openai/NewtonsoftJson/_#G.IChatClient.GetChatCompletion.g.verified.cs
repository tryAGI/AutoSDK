//HintName: G.IChatClient.GetChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get a stored chat completion. Only Chat Completions that have been created<br/>
        /// with the `store` parameter set to `true` will be returned.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> GetChatCompletionAsync(
            string completionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}