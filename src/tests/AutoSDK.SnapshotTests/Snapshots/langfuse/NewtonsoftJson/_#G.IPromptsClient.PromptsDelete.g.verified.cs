//HintName: G.IPromptsClient.PromptsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete prompt versions. If neither version nor label is specified, all versions of the prompt are deleted.
        /// </summary>
        /// <param name="promptName"></param>
        /// <param name="label"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PromptsDeleteAsync(
            string promptName,
            string? label = default,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}