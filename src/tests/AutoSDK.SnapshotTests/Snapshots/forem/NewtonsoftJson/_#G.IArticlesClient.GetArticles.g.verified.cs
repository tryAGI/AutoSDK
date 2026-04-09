//HintName: G.IArticlesClient.GetArticles.g.cs
#nullable enable

namespace G
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Published articles<br/>
        /// This endpoint allows the client to retrieve a list of articles.<br/>
        /// "Articles" are all the posts that users create on DEV that typically<br/>
        /// show up in the feed. They can be a blog post, a discussion question,<br/>
        /// a help thread etc. but is referred to as article within the code.<br/>
        /// By default it will return featured, published articles ordered<br/>
        /// by descending popularity.<br/>
        /// It supports pagination, each page will contain `30` articles by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="tag"></param>
        /// <param name="tags"></param>
        /// <param name="tagsExclude"></param>
        /// <param name="username"></param>
        /// <param name="state"></param>
        /// <param name="top"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ArticleIndex>> GetArticlesAsync(
            int? page = default,
            int? perPage = default,
            string? tag = default,
            string? tags = default,
            string? tagsExclude = default,
            string? username = default,
            global::G.GetArticlesState? state = default,
            int? top = default,
            int? collectionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}