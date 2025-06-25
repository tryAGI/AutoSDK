//HintName: G.IChatClient.DeleteChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Delete a stored chat completion. Only Chat Completions that have been<br/>
        /// created with the `store` parameter set to `true` can be deleted.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionDeleted> DeleteChatCompletionAsync(
            string completionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}