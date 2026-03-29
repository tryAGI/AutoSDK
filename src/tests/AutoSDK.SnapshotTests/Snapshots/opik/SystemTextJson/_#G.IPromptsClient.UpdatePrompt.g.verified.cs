//HintName: G.IPromptsClient.UpdatePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update prompt<br/>
        /// Update prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdatePromptAsync(
            global::System.Guid id,

            global::G.PromptUpdatable request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update prompt<br/>
        /// Update prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdatePromptAsync(
            global::System.Guid id,
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}