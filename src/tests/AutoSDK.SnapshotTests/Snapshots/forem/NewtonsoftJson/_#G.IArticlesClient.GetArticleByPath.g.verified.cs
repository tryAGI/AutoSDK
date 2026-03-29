//HintName: G.IArticlesClient.GetArticleByPath.g.cs
#nullable enable

namespace G
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Published article by path<br/>
        /// This endpoint allows the client to retrieve a single published article given its `path`.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetArticleByPathAsync(
            string username,
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}