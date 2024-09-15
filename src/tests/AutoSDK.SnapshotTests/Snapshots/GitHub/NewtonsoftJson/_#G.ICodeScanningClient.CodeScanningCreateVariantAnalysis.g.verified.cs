//HintName: G.ICodeScanningClient.CodeScanningCreateVariantAnalysis.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Create a CodeQL variant analysis<br/>
        /// Creates a new CodeQL variant analysis, which will run a CodeQL query against one or more repositories.<br/>
        /// Get started by learning more about [running CodeQL queries at scale with Multi-Repository Variant Analysis](https://docs.github.com/code-security/codeql-for-vs-code/getting-started-with-codeql-for-vs-code/running-codeql-queries-at-scale-with-multi-repository-variant-analysis).<br/>
        /// Use the `owner` and `repo` parameters in the URL to specify the controller repository that<br/>
        /// will be used for running GitHub Actions workflows and storing the results of the CodeQL variant analysis.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningVariantAnalysis> CodeScanningCreateVariantAnalysisAsync(
            string owner,
            string repo,
            global::G.CodeScanningCreateVariantAnalysisRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a CodeQL variant analysis<br/>
        /// Creates a new CodeQL variant analysis, which will run a CodeQL query against one or more repositories.<br/>
        /// Get started by learning more about [running CodeQL queries at scale with Multi-Repository Variant Analysis](https://docs.github.com/code-security/codeql-for-vs-code/getting-started-with-codeql-for-vs-code/running-codeql-queries-at-scale-with-multi-repository-variant-analysis).<br/>
        /// Use the `owner` and `repo` parameters in the URL to specify the controller repository that<br/>
        /// will be used for running GitHub Actions workflows and storing the results of the CodeQL variant analysis.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="language">
        /// The language targeted by the CodeQL query
        /// </param>
        /// <param name="queryPack">
        /// A Base64-encoded tarball containing a CodeQL query and all its dependencies
        /// </param>
        /// <param name="repositories">
        /// List of repository names (in the form `owner/repo-name`) to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="repositoryLists">
        /// List of repository lists to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="repositoryOwners">
        /// List of organization or user names whose repositories the query should be run against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningVariantAnalysis> CodeScanningCreateVariantAnalysisAsync(
            string owner,
            string repo,
            global::G.CodeScanningVariantAnalysisLanguage language,
            string queryPack,
            global::System.Collections.Generic.IList<string>? repositories = default,
            global::System.Collections.Generic.IList<string>? repositoryLists = default,
            global::System.Collections.Generic.IList<string>? repositoryOwners = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}