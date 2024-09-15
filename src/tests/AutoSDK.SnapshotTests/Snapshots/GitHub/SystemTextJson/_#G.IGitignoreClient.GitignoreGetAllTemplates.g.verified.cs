//HintName: G.IGitignoreClient.GitignoreGetAllTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface IGitignoreClient
    {
        /// <summary>
        /// Get all gitignore templates<br/>
        /// List all templates available to pass as an option when [creating a repository](https://docs.github.com/rest/repos/repos#create-a-repository-for-the-authenticated-user).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GitignoreGetAllTemplatesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}