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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the user created the marker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The description that the user gave the marker to help them remember why they marked the location. Is an empty string if the user didn’t provide one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The relative offset (in seconds) of the marker from the beginning of the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositionSeconds { get; set; }

        /// <summary>
        /// A URL that opens the video in Twitch Highlighter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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