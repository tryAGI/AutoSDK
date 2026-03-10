//HintName: G.IDubbingClient.CreateDubbingResourceByDubbingIdMigrateSegments.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Move Segments Between Speakers<br/>
        /// Change the attribution of one or more segments to a different speaker.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentMigrationResponse> CreateDubbingResourceByDubbingIdMigrateSegmentsAsync(
            string dubbingId,

            global::G.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Move Segments Between Speakers<br/>
        /// Change the attribution of one or more segments to a different speaker.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="segmentIds"></param>
        /// <param name="speakerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentMigrationResponse> CreateDubbingResourceByDubbingIdMigrateSegmentsAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segmentIds,
            string speakerId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}