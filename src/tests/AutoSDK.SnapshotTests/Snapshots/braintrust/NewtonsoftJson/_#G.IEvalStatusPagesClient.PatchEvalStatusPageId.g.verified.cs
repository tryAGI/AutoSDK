//HintName: G.IEvalStatusPagesClient.PatchEvalStatusPageId.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalStatusPagesClient
    {
        /// <summary>
        /// Partially update eval_status_page<br/>
        /// Partially update a eval_status_page object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="evalStatusPageId">
        /// EvalStatusPage id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalStatusPage> PatchEvalStatusPageIdAsync(
            global::System.Guid evalStatusPageId,

            global::G.PatchEvalStatusPage request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update eval_status_page<br/>
        /// Partially update a eval_status_page object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="evalStatusPageId">
        /// EvalStatusPage id
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalStatusPage> PatchEvalStatusPageIdAsync(
            global::System.Guid evalStatusPageId,
            string? name = default,
            string? description = default,
            string? logoUrl = default,
            global::G.EvalStatusPageTheme? theme = default,
            global::G.EvalStatusPageConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}