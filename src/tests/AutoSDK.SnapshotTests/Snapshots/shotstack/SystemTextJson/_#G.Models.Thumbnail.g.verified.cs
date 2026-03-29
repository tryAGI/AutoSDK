//HintName: G.Models.Thumbnail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate a thumbnail image for the video or image at a specific point from the timeline.
    /// </summary>
    public sealed partial class Thumbnail
    {
        /// <summary>
        /// The point on the timeline in seconds to capture a single frame to use as the thumbnail image.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("capture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Capture { get; set; }

        /// <summary>
        /// Scale the thumbnail size to a fraction of the viewport size - i.e. setting the scale to 0.5 will scale  the thumbnail to half the size of the viewport.<br/>
        /// Example: 0.3F
        /// </summary>
        /// <example>0.3F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Scale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail" /> class.
        /// </summary>
        /// <param name="capture">
        /// The point on the timeline in seconds to capture a single frame to use as the thumbnail image.<br/>
        /// Example: 1
        /// </param>
        /// <param name="scale">
        /// Scale the thumbnail size to a fraction of the viewport size - i.e. setting the scale to 0.5 will scale  the thumbnail to half the size of the viewport.<br/>
        /// Example: 0.3F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Thumbnail(
            double capture,
            double scale)
        {
            this.Capture = capture;
            this.Scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail" /> class.
        /// </summary>
        public Thumbnail()
        {
        }
    }
}