//HintName: G.IReposClient.ReposDeleteTagProtection.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Deprecated - Delete a tag protection state for a repository<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This operation is deprecated and will be removed after August 30, 2024. Use the "[Repository Rulesets](https://docs.github.com/rest/repos/rules#delete-a-repository-ruleset)" endpoint instead.<br/>
        /// This deletes a tag protection state for a repository.<br/>
        /// This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tagProtectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task ReposDeleteTagProtectionAsync(
            string owner,
            string repo,
            int tagProtectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}