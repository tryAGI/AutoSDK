//HintName: G.Models.OCRInferenceResponseParentId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
    /// </summary>
    public sealed partial class OCRInferenceResponseParentId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}