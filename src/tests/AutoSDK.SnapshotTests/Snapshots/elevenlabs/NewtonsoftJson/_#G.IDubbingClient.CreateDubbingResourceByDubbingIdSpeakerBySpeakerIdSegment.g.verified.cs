//HintName: G.IDubbingClient.CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegment.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create A Segment For The Speaker<br/>
        /// Creates a new segment in dubbing resource with a start and end time for the speaker in every available language. Does not automatically generate transcripts/translations/audio.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentCreateResponse> CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentAsync(
            string dubbingId,
            string speakerId,
            global::G.SegmentCreatePayload request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create A Segment For The Speaker<br/>
        /// Creates a new segment in dubbing resource with a start and end time for the speaker in every available language. Does not automatically generate transcripts/translations/audio.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="translations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentCreateResponse> CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentAsync(
            string dubbingId,
            string speakerId,
            double startTime,
            double endTime,
            string? xiApiKey = default,
            string? text = default,
            global::System.Collections.Generic.Dictionary<string, string>? translations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}