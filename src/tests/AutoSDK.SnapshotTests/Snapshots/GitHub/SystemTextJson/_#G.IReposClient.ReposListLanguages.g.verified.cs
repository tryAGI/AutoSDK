//HintName: G.IReposClient.ReposListLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repository languages<br/>
        /// Lists languages for the specified repository. The value shown for each language is the number of bytes of code written in that language.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, int>> ReposListLanguagesAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}