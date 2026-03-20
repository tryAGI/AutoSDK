//HintName: G.IReposClient.ReposCodeownersErrors.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List CODEOWNERS errors<br/>
        /// List any syntax errors that are detected in the CODEOWNERS<br/>
        /// file.<br/>
        /// For more information about the correct CODEOWNERS syntax,<br/>
        /// see "[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeownersErrors> ReposCodeownersErrorsAsync(
            string owner,
            string repo,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}