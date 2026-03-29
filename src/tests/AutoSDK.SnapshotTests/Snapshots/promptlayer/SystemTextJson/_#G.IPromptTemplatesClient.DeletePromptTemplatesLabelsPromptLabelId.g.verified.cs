//HintName: G.IPromptTemplatesClient.DeletePromptTemplatesLabelsPromptLabelId.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Delete Prompt Template Label
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePromptTemplatesLabelsPromptLabelIdAsync(
            int promptLabelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}