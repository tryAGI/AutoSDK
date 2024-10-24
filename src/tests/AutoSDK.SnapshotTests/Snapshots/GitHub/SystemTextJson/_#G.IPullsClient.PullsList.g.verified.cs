//HintName: G.IPullsClient.PullsList.g.cs
#nullable enable

namespace G
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// List pull requests<br/>
        /// Lists pull requests in a specified repository.<br/>
        /// Draft pull requests are available in public repositories with GitHub<br/>
        /// Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing<br/>
        /// plans, and in public and private repositories with GitHub Team and GitHub Enterprise<br/>
        /// Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products)<br/>
        /// in the GitHub Help documentation.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="head"></param>
        /// <param name="base"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PullRequestSimple>> PullsListAsync(
            string owner,
            string repo,
            global::G.PullsListState? state = default,
            string? head = default,
            string? @base = default,
            global::G.PullsListSort? sort = default,
            global::G.PullsListDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}