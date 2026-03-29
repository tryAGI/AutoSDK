//HintName: G.Models.VideoSegmentationOneOf0Dynamic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
    /// </summary>
    public sealed partial class VideoSegmentationOneOf0Dynamic
    {
        /// <summary>
        /// The minimum duration in seconds for each segment.<br/>
        /// The platform divides the video into segments that are at least this long. Segments adapt to scene changes and content boundaries and may be longer than the minimum.<br/>
        /// **Example**: With `min_duration_sec: 3`, segments might be: [0-3.2s], [3.2-7.8s], [7.8-12.1s]<br/>
        /// Default Value: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_duration_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinDurationSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationOneOf0Dynamic" /> class.
        /// </summary>
        /// <param name="minDurationSec">
        /// The minimum duration in seconds for each segment.<br/>
        /// The platform divides the video into segments that are at least this long. Segments adapt to scene changes and content boundaries and may be longer than the minimum.<br/>
        /// **Example**: With `min_duration_sec: 3`, segments might be: [0-3.2s], [3.2-7.8s], [7.8-12.1s]<br/>
        /// Default Value: 4
        /// </param>
        public VideoSegmentationOneOf0Dynamic(
            int minDurationSec)
        {
            this.MinDurationSec = minDurationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationOneOf0Dynamic" /> class.
        /// </summary>
        public VideoSegmentationOneOf0Dynamic()
        {
        }
    }
}