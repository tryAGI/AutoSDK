//HintName: G.Models.PublishedProjectMetadataMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed metadata about the published project
    /// </summary>
    public sealed partial class PublishedProjectMetadataMetadata
    {
        /// <summary>
        /// The title of the published project<br/>
        /// Example: My Video Project
        /// </summary>
        /// <example>My Video Project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Duration of the published content in seconds (rounded to nearest millisecond)<br/>
        /// Example: 125.456
        /// </summary>
        /// <example>125.456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Human-readable duration in HH:MM:SS format<br/>
        /// Example: 00:02:05
        /// </summary>
        /// <example>00:02:05</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_formatted")]
        public string? DurationFormatted { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the project was published<br/>
        /// Example: 2025-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2025-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// Information about the user who published the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_by")]
        public global::G.PublishedProjectMetadataMetadataPublishedBy? PublishedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadataMetadata" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the published project<br/>
        /// Example: My Video Project
        /// </param>
        /// <param name="durationSeconds">
        /// Duration of the published content in seconds (rounded to nearest millisecond)<br/>
        /// Example: 125.456
        /// </param>
        /// <param name="durationFormatted">
        /// Human-readable duration in HH:MM:SS format<br/>
        /// Example: 00:02:05
        /// </param>
        /// <param name="publishedAt">
        /// ISO 8601 timestamp of when the project was published<br/>
        /// Example: 2025-01-15T10:30:00.000Z
        /// </param>
        /// <param name="publishedBy">
        /// Information about the user who published the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishedProjectMetadataMetadata(
            string? title,
            double? durationSeconds,
            string? durationFormatted,
            global::System.DateTime? publishedAt,
            global::G.PublishedProjectMetadataMetadataPublishedBy? publishedBy)
        {
            this.Title = title;
            this.DurationSeconds = durationSeconds;
            this.DurationFormatted = durationFormatted;
            this.PublishedAt = publishedAt;
            this.PublishedBy = publishedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadataMetadata" /> class.
        /// </summary>
        public PublishedProjectMetadataMetadata()
        {
        }
    }
}