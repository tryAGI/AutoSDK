//HintName: G.IPromptsClient.PatchPromptId.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Partially update prompt<br/>
        /// Partially update a prompt object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="promptId">
        /// Prompt id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt> PatchPromptIdAsync(
            global::System.Guid promptId,

            global::G.PatchPrompt request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update prompt<br/>
        /// Partially update a prompt object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="promptId">
        /// Prompt id
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="slug">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt> PatchPromptIdAsync(
            global::System.Guid promptId,
            string? name = default,
            string? slug = default,
            string? description = default,
            global::G.PromptDataNullish? promptData = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}