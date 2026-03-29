//HintName: G.IPromptsClient.RetrievePromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Retrieve prompt version<br/>
        /// Retrieve prompt version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionDetail> RetrievePromptVersionAsync(

            global::G.PromptVersionRetrieveDetail request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve prompt version<br/>
        /// Retrieve prompt version
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit"></param>
        /// <param name="projectName">
        /// If provided, scopes the search to the specified project
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionDetail> RetrievePromptVersionAsync(
            string name,
            string? commit = default,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}