//HintName: G.IArticlesClient.GetArticleById.g.cs
#nullable enable

namespace G
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Published article by id<br/>
        /// This endpoint allows the client to retrieve a single published article given its `id`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetArticleByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}