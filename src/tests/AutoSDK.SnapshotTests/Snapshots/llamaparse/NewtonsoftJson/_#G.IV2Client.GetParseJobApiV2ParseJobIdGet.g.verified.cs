//HintName: G.IV2Client.GetParseJobApiV2ParseJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Get Parse Job<br/>
        /// Retrieve a parse job with optional expanded content.<br/>
        /// By default returns job metadata only. Use `expand` to include<br/>
        /// parsed content:<br/>
        /// - `text` — plain text output<br/>
        /// - `markdown` — markdown output<br/>
        /// - `items` — structured page-by-page output<br/>
        /// - `job_metadata` — usage and processing details<br/>
        /// Content metadata fields (e.g. `text_content_metadata`) return<br/>
        /// presigned URLs for downloading large results.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="expand">
        /// Fields to include: text, markdown, items, metadata, job_metadata, text_content_metadata, markdown_content_metadata, items_content_metadata, metadata_content_metadata, xlsx_content_metadata, output_pdf_content_metadata, images_content_metadata. Metadata fields include presigned URLs.
        /// </param>
        /// <param name="imageFilenames">
        /// Filter to specific image filenames (optional). Example: image_0.png,image_1.jpg
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseResultResponse> GetParseJobApiV2ParseJobIdGetAsync(
            string jobId,
            global::System.Collections.Generic.IList<string>? expand = default,
            string? imageFilenames = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}