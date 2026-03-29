//HintName: G.IPromptsClient.DeletePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete a prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}