//HintName: G.IEvalStatusPagesClient.PutEvalStatusPage.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalStatusPagesClient
    {
        /// <summary>
        /// Create or replace eval_status_page<br/>
        /// Create or replace eval_status_page. If there is an existing eval_status_page with the same name as the one specified in the request, will replace the existing eval_status_page with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalStatusPage> PutEvalStatusPageAsync(

            global::G.CreateEvalStatusPage request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace eval_status_page<br/>
        /// Create or replace eval_status_page. If there is an existing eval_status_page with the same name as the one specified in the request, will replace the existing eval_status_page with the provided fields
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the eval status page belongs under
        /// </param>
        /// <param name="name">
        /// Name of the eval status page
        /// </param>
        /// <param name="description">
        /// Textual description of the eval status page
        /// </param>
        /// <param name="logoUrl">
        /// URL of the logo to display on the page
        /// </param>
        /// <param name="theme">
        /// The theme for the page
        /// </param>
        /// <param name="config">
        /// Configuration for what data to display
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalStatusPage> PutEvalStatusPageAsync(
            global::System.Guid projectId,
            string name,
            global::G.EvalStatusPageTheme theme,
            global::G.EvalStatusPageConfig config,
            string? description = default,
            string? logoUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}