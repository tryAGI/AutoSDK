//HintName: G.Models.StreamMarkers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamMarkers
    {
        /// <summary>
        /// The ID of the user that created the marker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// A list of videos that contain markers. The list contains a single video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videos", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Videos { get; set; } = default!;

        /// <summary>
        /// An ID that identifies this video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoId { get; set; } = default!;

        /// <summary>
        /// The list of markers in this video. The list in ascending order by when the marker was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StreamMarkersMarker> Markers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamMarkers" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user that created the marker.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="videos">
        /// A list of videos that contain markers. The list contains a single video.
        /// </param>
        /// <param name="videoId">
        /// An ID that identifies this video.
        /// </param>
        /// <param name="markers">
        /// The list of markers in this video. The list in ascending order by when the marker was created.
        /// </param>
        public StreamMarkers(
            string userId,
            string userName,
            string userLogin,
            global::System.Collections.Generic.IList<object> videos,
            string videoId,
            global::System.Collections.Generic.IList<global::G.StreamMarkersMarker> markers)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.Videos = videos ?? throw new global::System.ArgumentNullException(nameof(videos));
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Markers = markers ?? throw new global::System.ArgumentNullException(nameof(markers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamMarkers" /> class.
        /// </summary>
        public StreamMarkers()
        {
        }
    }
}