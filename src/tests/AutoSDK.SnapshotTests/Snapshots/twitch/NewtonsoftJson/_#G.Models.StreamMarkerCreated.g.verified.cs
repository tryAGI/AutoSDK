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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the user created the marker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The relative offset (in seconds) of the marker from the beginning of the stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public int PositionSeconds { get; set; } = default!;

        /// <summary>
        /// A description that the user gave the marker to help them remember why they marked the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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