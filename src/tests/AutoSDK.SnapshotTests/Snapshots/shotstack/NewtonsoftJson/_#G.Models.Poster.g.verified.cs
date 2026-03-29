//HintName: G.Models.Poster.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate a poster image for the video at a specific point from the timeline. The poster image size will match the size of the output video.
    /// </summary>
    public sealed partial class Poster
    {
        /// <summary>
        /// The point on the timeline in seconds to capture a single frame to use as the poster image.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("capture", Required = global::Newtonsoft.Json.Required.Always)]
        public double Capture { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Poster" /> class.
        /// </summary>
        /// <param name="capture">
        /// The point on the timeline in seconds to capture a single frame to use as the poster image.<br/>
        /// Example: 1
        /// </param>
        public Poster(
            double capture)
        {
            this.Capture = capture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Poster" /> class.
        /// </summary>
        public Poster()
        {
        }
    }
}