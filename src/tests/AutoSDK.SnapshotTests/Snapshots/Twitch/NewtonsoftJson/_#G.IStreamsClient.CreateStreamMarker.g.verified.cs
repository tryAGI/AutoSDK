//HintName: G.IStreamsClient.CreateStreamMarker.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Adds a marker to a live stream.<br/>
        /// Adds a marker to a live stream. A marker is an arbitrary point in a live stream that the broadcaster or editor wants to mark, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).<br/>
        /// You may not add markers:<br/>
        /// * If the stream is not live<br/>
        /// * If the stream has not enabled video on demand (VOD)<br/>
        /// * If the stream is a premiere (a live, first-viewing event that combines uploaded videos with live chat)<br/>
        /// * If the stream is a rerun of a past broadcast, including past premieres.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateStreamMarkerResponse> CreateStreamMarkerAsync(
            global::G.CreateStreamMarkerBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds a marker to a live stream.<br/>
        /// Adds a marker to a live stream. A marker is an arbitrary point in a live stream that the broadcaster or editor wants to mark, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).<br/>
        /// You may not add markers:<br/>
        /// * If the stream is not live<br/>
        /// * If the stream has not enabled video on demand (VOD)<br/>
        /// * If the stream is a premiere (a live, first-viewing event that combines uploaded videos with live chat)<br/>
        /// * If the stream is a rerun of a past broadcast, including past premieres.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.
        /// </summary>
        /// <param name="userId">
        /// The ID of the broadcaster that’s streaming content. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.
        /// </param>
        /// <param name="description">
        /// A short description of the marker to help the user remember why they marked the location. The maximum length of the description is 140 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateStreamMarkerResponse> CreateStreamMarkerAsync(
            string userId,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}