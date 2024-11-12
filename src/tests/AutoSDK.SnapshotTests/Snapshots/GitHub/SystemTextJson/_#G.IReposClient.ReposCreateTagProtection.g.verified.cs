//HintName: G.IReposClient.ReposCreateTagProtection.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Deprecated - Create a tag protection state for a repository<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This operation is deprecated and will be removed after August 30, 2024. Use the "[Repository Rulesets](https://docs.github.com/rest/repos/rules#create-a-repository-ruleset)" endpoint instead.<br/>
        /// This creates a tag protection state for a repository.<br/>
        /// This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TagProtection> ReposCreateTagProtectionAsync(
            string owner,
            string repo,
            global::G.ReposCreateTagProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deprecated - Create a tag protection state for a repository<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This operation is deprecated and will be removed after August 30, 2024. Use the "[Repository Rulesets](https://docs.github.com/rest/repos/rules#create-a-repository-ruleset)" endpoint instead.<br/>
        /// This creates a tag protection state for a repository.<br/>
        /// This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pattern">
        /// An optional glob pattern to match against when enforcing tag protection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TagProtection> ReposCreateTagProtectionAsync(
            string owner,
            string repo,
            string pattern,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}