//HintName: G.Models.VideoSegmentationOneOf1Fixed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoSegmentationOneOf1Fixed
    {
        /// <summary>
        /// The duration in seconds for each segment.<br/>
        /// The platform divides the video into segments of this exact length. The final segment may be shorter if the video duration is not evenly divisible.<br/>
        /// **Example**: With `duration_sec: 5`, a 12-second video produces segments: [0-5s], [5-10s], [10-12s].<br/>
        /// Default Value: 6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationOneOf1Fixed" /> class.
        /// </summary>
        /// <param name="durationSec">
        /// The duration in seconds for each segment.<br/>
        /// The platform divides the video into segments of this exact length. The final segment may be shorter if the video duration is not evenly divisible.<br/>
        /// **Example**: With `duration_sec: 5`, a 12-second video produces segments: [0-5s], [5-10s], [10-12s].<br/>
        /// Default Value: 6
        /// </param>
        public VideoSegmentationOneOf1Fixed(
            int durationSec)
        {
            this.DurationSec = durationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationOneOf1Fixed" /> class.
        /// </summary>
        public VideoSegmentationOneOf1Fixed()
        {
        }
    }
}