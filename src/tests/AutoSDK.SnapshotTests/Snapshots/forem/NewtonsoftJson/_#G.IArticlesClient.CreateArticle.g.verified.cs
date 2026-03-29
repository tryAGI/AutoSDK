//HintName: G.IArticlesClient.CreateArticle.g.cs
#nullable enable

namespace G
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Publish article<br/>
        /// This endpoint allows the client to create a new article.<br/>
        /// "Articles" are all the posts that users create on DEV that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but is referred to as article within the code.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateArticleAsync(

            global::G.Article request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish article<br/>
        /// This endpoint allows the client to create a new article.<br/>
        /// "Articles" are all the posts that users create on DEV that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but is referred to as article within the code.
        /// </summary>
        /// <param name="article1"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateArticleAsync(
            global::G.ArticleArticle1? article1 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}