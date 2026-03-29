//HintName: G.IPromptsClient.UpdatePromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update a specific version of a prompt<br/>
        /// Updates metadata for a specific prompt version. **This endpoint only supports updating the `label_id` field.**<br/>
        /// Prompt versions are immutable — their `string`, `parameters`, and `model` content cannot be changed after creation. To update prompt content, use `PUT /prompts/{promptId}` which creates a new version with the updated content.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptVersionAsync(
            string promptId,
            global::System.Guid versionId,

            global::G.UpdatePromptVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a specific version of a prompt<br/>
        /// Updates metadata for a specific prompt version. **This endpoint only supports updating the `label_id` field.**<br/>
        /// Prompt versions are immutable — their `string`, `parameters`, and `model` content cannot be changed after creation. To update prompt content, use `PUT /prompts/{promptId}` which creates a new version with the updated content.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="labelId">
        /// The label to assign to this version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptVersionAsync(
            string promptId,
            global::System.Guid versionId,
            global::System.Guid? labelId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}