//HintName: G.Models.OptimizationSegmentInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationSegmentInfo
    {
        /// <summary>
        /// Unique identifier of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Number of non-deleted points in the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PointsCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationSegmentInfo" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier of the segment.
        /// </param>
        /// <param name="pointsCount">
        /// Number of non-deleted points in the segment.
        /// </param>
        public OptimizationSegmentInfo(
            global::System.Guid uuid,
            int pointsCount)
        {
            this.Uuid = uuid;
            this.PointsCount = pointsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationSegmentInfo" /> class.
        /// </summary>
        public OptimizationSegmentInfo()
        {
        }
    }
}