//HintName: G.Models.StreamMarkerCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamMarkerCreated
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
        /// The relative offset (in seconds) of the marker from the beginning of the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositionSeconds { get; set; }

        /// <summary>
        /// A description that the user gave the marker to help them remember why they marked the location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamMarkerCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this marker.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time (in RFC3339 format) of when the user created the marker.
        /// </param>
        /// <param name="positionSeconds">
        /// The relative offset (in seconds) of the marker from the beginning of the stream.
        /// </param>
        /// <param name="description">
        /// A description that the user gave the marker to help them remember why they marked the location.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamMarkerCreated(
            string id,
            global::System.DateTime createdAt,
            int positionSeconds,
            string description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.PositionSeconds = positionSeconds;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamMarkerCreated" /> class.
        /// </summary>
        public StreamMarkerCreated()
        {
        }
    }
}