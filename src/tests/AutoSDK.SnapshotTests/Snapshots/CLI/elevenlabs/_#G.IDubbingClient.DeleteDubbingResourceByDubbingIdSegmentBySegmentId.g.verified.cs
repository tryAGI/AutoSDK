//HintName: G.IDubbingClient.DeleteDubbingResourceByDubbingIdSegmentBySegmentId.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Deletes A Single Segment<br/>
        /// Deletes a single segment from the dubbing.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// ID of the segment
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentDeleteResponse> DeleteDubbingResourceByDubbingIdSegmentBySegmentIdAsync(
            string dubbingId,
            string segmentId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}