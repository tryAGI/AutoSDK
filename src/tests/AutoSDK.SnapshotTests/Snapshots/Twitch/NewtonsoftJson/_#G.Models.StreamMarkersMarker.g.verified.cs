//HintName: G.Models.StreamMarkersMarker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamMarkersMarker
    {
        /// <summary>
        /// An ID that identifies this marker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the user created the marker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The description that the user gave the marker to help them remember why they marked the location. Is an empty string if the user didn’t provide one.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The relative offset (in seconds) of the marker from the beginning of the stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public int PositionSeconds { get; set; } = default!;

        /// <summary>
        /// A URL that opens the video in Twitch Highlighter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamMarkersMarker" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this marker.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time (in RFC3339 format) of when the user created the marker.
        /// </param>
        /// <param name="description">
        /// The description that the user gave the marker to help them remember why they marked the location. Is an empty string if the user didn’t provide one.
        /// </param>
        /// <param name="positionSeconds">
        /// The relative offset (in seconds) of the marker from the beginning of the stream.
        /// </param>
        /// <param name="url">
        /// A URL that opens the video in Twitch Highlighter.
        /// </param>
        public StreamMarkersMarker(
            string id,
            global::System.DateTime createdAt,
            string description,
            int positionSeconds,
            string url)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PositionSeconds = positionSeconds;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamMarkersMarker" /> class.
        /// </summary>
        public StreamMarkersMarker()
        {
        }
    }
}