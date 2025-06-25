﻿//HintName: G.IScheduleClient.UpdateChannelStreamScheduleSegment.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduleClient
    {
        /// <summary>
        /// Updates a scheduled broadcast segment.<br/>
        /// Updates a scheduled broadcast segment.<br/>
        /// For recurring segments, updating a segment’s title, category, duration, and timezone, changes all segments in the recurring schedule, not just the specified segment.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateChannelStreamScheduleSegmentResponse> UpdateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            global::G.UpdateChannelStreamScheduleSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a scheduled broadcast segment.<br/>
        /// Updates a scheduled broadcast segment.<br/>
        /// For recurring segments, updating a segment’s title, category, duration, and timezone, changes all segments in the recurring schedule, not just the specified segment.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="startTime">
        /// The date and time that the broadcast segment starts. Specify the date and time in RFC3339 format (for example, 2022-08-02T06:00:00Z).  <br/>
        ///   <br/>
        /// **NOTE**: Only partners and affiliates may update a broadcast’s start time and only for non-recurring segments.
        /// </param>
        /// <param name="duration">
        /// The length of time, in minutes, that the broadcast is scheduled to run. The duration must be in the range 30 through 1380 (23 hours).
        /// </param>
        /// <param name="categoryId">
        /// The ID of the category that best represents the broadcast’s content. To get the category ID, use the [Search Categories](https://dev.twitch.tv/docs/api/reference#search-categories) endpoint.
        /// </param>
        /// <param name="title">
        /// The broadcast’s title. The title may contain a maximum of 140 characters.
        /// </param>
        /// <param name="isCanceled">
        /// A Boolean value that indicates whether the broadcast is canceled. Set to **true** to cancel the segment.  <br/>
        ///   <br/>
        /// **NOTE**: For recurring segments, the API cancels the first segment after the current UTC date and time and not the specified segment (unless the specified segment is the next segment after the current UTC date and time).
        /// </param>
        /// <param name="timezone">
        /// The time zone where the broadcast takes place. Specify the time zone using [IANA time zone database](https://www.iana.org/time-zones) format (for example, America/New\_York).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateChannelStreamScheduleSegmentResponse> UpdateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            global::System.DateTime? startTime = default,
            string? duration = default,
            string? categoryId = default,
            string? title = default,
            bool? isCanceled = default,
            string? timezone = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}