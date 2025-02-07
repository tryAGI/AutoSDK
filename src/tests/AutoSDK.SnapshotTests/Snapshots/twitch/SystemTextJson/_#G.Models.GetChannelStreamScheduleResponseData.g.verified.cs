//HintName: G.Models.GetChannelStreamScheduleResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The broadcaster’s streaming schedule.
    /// </summary>
    public sealed partial class GetChannelStreamScheduleResponseData
    {
        /// <summary>
        /// The list of broadcasts in the broadcaster’s streaming schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelStreamScheduleSegment> Segments { get; set; }

        /// <summary>
        /// The ID of the broadcaster that owns the broadcast schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vacation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetChannelStreamScheduleResponseDataVacation Vacation { get; set; }

        /// <summary>
        /// The information used to page through a list of results. The object is empty if there are no more pages left to page through. [Read more](https://dev.twitch.tv/docs/api/guide#pagination).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetChannelStreamScheduleResponseDataPagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponseData" /> class.
        /// </summary>
        /// <param name="segments">
        /// The list of broadcasts in the broadcaster’s streaming schedule.
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that owns the broadcast schedule.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="vacation">
        /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
        /// </param>
        /// <param name="pagination">
        /// The information used to page through a list of results. The object is empty if there are no more pages left to page through. [Read more](https://dev.twitch.tv/docs/api/guide#pagination).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelStreamScheduleResponseData(
            global::System.Collections.Generic.IList<global::G.ChannelStreamScheduleSegment> segments,
            string broadcasterId,
            string broadcasterName,
            string broadcasterLogin,
            global::G.GetChannelStreamScheduleResponseDataVacation vacation,
            global::G.GetChannelStreamScheduleResponseDataPagination? pagination)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.Vacation = vacation ?? throw new global::System.ArgumentNullException(nameof(vacation));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponseData" /> class.
        /// </summary>
        public GetChannelStreamScheduleResponseData()
        {
        }
    }
}