//HintName: G.IPromptsClient.UpdatePromptName.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update prompt name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptNameAsync(
            string id,

            global::G.PostedPromptName request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update prompt name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptNameAsync(
            string id,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}