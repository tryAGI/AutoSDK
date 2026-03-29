//HintName: G.IV2Client.CreateExtractJobApiV2ExtractPost.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Create Extract Job<br/>
        /// Create an extraction job.<br/>
        /// Extracts structured data from a document using either a saved<br/>
        /// configuration or an inline JSON Schema.<br/>
        /// ## Input<br/>
        /// Provide exactly one of:<br/>
        /// - `configuration_id` — reference a saved extraction config<br/>
        /// - `configuration` — inline configuration with a `data_schema`<br/>
        /// ## Document input<br/>
        /// Set `document_input_value` to a file ID (`dfl-...`) or a<br/>
        /// completed parse job ID (`pjb-...`).<br/>
        /// The job runs asynchronously. Poll `GET /extract/{job_id}` or<br/>
        /// register a webhook to monitor completion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractV2Job> CreateExtractJobApiV2ExtractPostAsync(

            global::G.ExtractV2JobCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Extract Job<br/>
        /// Create an extraction job.<br/>
        /// Extracts structured data from a document using either a saved<br/>
        /// configuration or an inline JSON Schema.<br/>
        /// ## Input<br/>
        /// Provide exactly one of:<br/>
        /// - `configuration_id` — reference a saved extraction config<br/>
        /// - `configuration` — inline configuration with a `data_schema`<br/>
        /// ## Document input<br/>
        /// Set `document_input_value` to a file ID (`dfl-...`) or a<br/>
        /// completed parse job ID (`pjb-...`).<br/>
        /// The job runs asynchronously. Poll `GET /extract/{job_id}` or<br/>
        /// register a webhook to monitor completion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="documentInputValue">
        /// File ID or Parse Job ID to extract from
        /// </param>
        /// <param name="configurationId">
        /// Saved extract configuration ID (mutually exclusive with configuration)
        /// </param>
        /// <param name="configuration">
        /// Inline configuration with extract options and optional parse settings
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractV2Job> CreateExtractJobApiV2ExtractPostAsync(
            string documentInputValue,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations = default,
            string? configurationId = default,
            global::G.ExtractConfiguration? configuration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}