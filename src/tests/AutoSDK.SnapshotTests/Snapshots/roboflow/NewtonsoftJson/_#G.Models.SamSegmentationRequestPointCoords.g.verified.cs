//HintName: G.Models.SamSegmentationRequestPointCoords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The coordinates of the interactive points used during decoding. Each point (x,y pair) corresponds to a label in point_labels.<br/>
    /// Default Value: [[0F, 0F]]
    /// </summary>
    public sealed partial class SamSegmentationRequestPointCoords
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}