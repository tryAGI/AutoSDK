//HintName: G.Models.Sam3SegmentationRequestNmsIouThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// IoU threshold for cross-prompt NMS. If None, NMS is disabled. Must be in [0.0, 1.0] when set.
    /// </summary>
    public sealed partial class Sam3SegmentationRequestNmsIouThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}