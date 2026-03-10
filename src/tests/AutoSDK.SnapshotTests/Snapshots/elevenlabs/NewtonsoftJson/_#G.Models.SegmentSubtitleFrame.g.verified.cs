//HintName: G.Models.SegmentSubtitleFrame.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentSubtitleFrame
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lines", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Lines { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentSubtitleFrame" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="lines"></param>
        public SegmentSubtitleFrame(
            double startTime,
            double endTime,
            global::System.Collections.Generic.IList<string> lines)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentSubtitleFrame" /> class.
        /// </summary>
        public SegmentSubtitleFrame()
        {
        }
    }
}