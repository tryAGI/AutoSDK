//HintName: G.IOrganizationsClient.Import.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Import member tags from CSV<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Upload a CSV file to bulk import member tags and assign them to organization members.<br/>
        /// The CSV file must contain `email` and `tags` columns. The `tags` column should contain comma-separated tag labels (quoted if they contain commas). Tags that do not exist will be created.<br/>
        /// Optionally, you can specify `bulk_tags` as a comma-separated list of tags to apply to all users in the CSV file.<br/>
        /// The import runs asynchronously. Use the returned import job ID to check the status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiOrganizationsMemberTagsImportsCreateResponse> ImportAsync(
            int id,

            global::G.OrganizationMemberTagImportCreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Import member tags from CSV<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Upload a CSV file to bulk import member tags and assign them to organization members.<br/>
        /// The CSV file must contain `email` and `tags` columns. The `tags` column should contain comma-separated tag labels (quoted if they contain commas). Tags that do not exist will be created.<br/>
        /// Optionally, you can specify `bulk_tags` as a comma-separated list of tags to apply to all users in the CSV file.<br/>
        /// The import runs asynchronously. Use the returned import job ID to check the status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bulkTags"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiOrganizationsMemberTagsImportsCreateResponse> ImportAsync(
            int id,
            string bulkTags,
            byte[] file,
            string filename,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}