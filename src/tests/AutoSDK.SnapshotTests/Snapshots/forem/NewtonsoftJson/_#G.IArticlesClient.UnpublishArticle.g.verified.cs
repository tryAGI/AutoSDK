//HintName: G.IArticlesClient.UnpublishArticle.g.cs
#nullable enable

namespace G
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Unpublish an article<br/>
        /// This endpoint allows the client to unpublish an article.<br/>
        /// The user associated with the API key must have any 'admin' or 'moderator' role.<br/>
        /// The article will be unpublished and will no longer be visible to the public. It will remain<br/>
        /// in the database and will set back to draft status on the author's posts dashboard. Any<br/>
        /// notifications associated with the article will be deleted. Any comments on the article<br/>
        /// will remain.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UnpublishArticleAsync(
            int id,
            string? note = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}