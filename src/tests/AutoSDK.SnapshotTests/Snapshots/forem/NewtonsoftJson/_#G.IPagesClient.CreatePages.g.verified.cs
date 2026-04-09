//HintName: G.IPagesClient.CreatePages.g.cs
#nullable enable

namespace G
{
    public partial interface IPagesClient
    {
        /// <summary>
        /// pages<br/>
        /// This endpoint allows the client to create a new page.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePagesAsync(

            global::G.CreatePagesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// pages<br/>
        /// This endpoint allows the client to create a new page.
        /// </summary>
        /// <param name="title">
        /// Title of the page
        /// </param>
        /// <param name="slug">
        /// Used to link to this page in URLs, must be unique and URL-safe
        /// </param>
        /// <param name="description">
        /// For internal use, helps similar pages from one another
        /// </param>
        /// <param name="bodyMarkdown">
        /// The text (in markdown) of the ad (required)
        /// </param>
        /// <param name="bodyJson">
        /// For JSON pages, the JSON body
        /// </param>
        /// <param name="isTopLevelPath">
        /// If true, the page is available at '/{slug}' instead of '/page/{slug}', use with caution
        /// </param>
        /// <param name="template">
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePagesAsync(
            string? title = default,
            string? slug = default,
            string? description = default,
            string? bodyMarkdown = default,
            string? bodyJson = default,
            bool? isTopLevelPath = default,
            global::G.CreatePagesRequestTemplate? template = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}