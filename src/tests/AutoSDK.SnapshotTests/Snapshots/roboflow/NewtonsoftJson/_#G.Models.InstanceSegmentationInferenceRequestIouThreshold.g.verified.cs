//HintName: G.Models.InstanceSegmentationInferenceRequestIouThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The IoU threhsold that must be met for a box pair to be considered duplicate during NMS<br/>
    /// Default Value: 0.3F
    /// </summary>
    public sealed partial class InstanceSegmentationInferenceRequestIouThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}