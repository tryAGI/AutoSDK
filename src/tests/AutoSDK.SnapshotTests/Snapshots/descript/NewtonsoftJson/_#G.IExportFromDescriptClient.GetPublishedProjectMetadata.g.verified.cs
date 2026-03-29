//HintName: G.IExportFromDescriptClient.GetPublishedProjectMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IExportFromDescriptClient
    {
        /// <summary>
        /// Get Published Project Metadata<br/>
        /// Retrieve metadata for a published Descript project by its URL slug. This endpoint provides information<br/>
        /// about the published project including title, duration, publisher details, privacy settings, and subtitles.<br/>
        /// This endpoint requires authentication using a personal token and is subject to rate limiting of 1000<br/>
        /// requests per hour per user.
        /// </summary>
        /// <param name="publishedProjectSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PublishedProjectMetadata> GetPublishedProjectMetadataAsync(
            string publishedProjectSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}