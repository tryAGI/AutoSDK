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
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Number of non-deleted points in the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PointsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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