//HintName: G.IInformationClient.GetTopBlogPosts.g.cs
#nullable enable

namespace G
{
    public partial interface IInformationClient
    {
        /// <summary>
        /// Get Top Blog Posts<br/>
        /// Returns the top blog posts from the Dedoose blog.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BlogPost>> GetTopBlogPostsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}