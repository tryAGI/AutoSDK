//HintName: G.Models.SamSegmentationRequestPointLabels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The labels of the interactive points used during decoding. A 1 represents a positive point (part of the object to be segmented). A -1 represents a negative point (not part of the object to be segmented). Each label corresponds to a point in point_coords.<br/>
    /// Default Value: [-1]
    /// </summary>
    public sealed partial class SamSegmentationRequestPointLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}