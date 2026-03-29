//HintName: G.IPromptsClient.SerializePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Serialize Prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SerializePromptAsync(
            string id,
            string? versionId = default,
            string? environment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}