//HintName: G.Models.SamSegmentationRequestMaskInputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the mask input. Must be one of json or binary. If binary, mask input is expected to be a binary numpy array.<br/>
    /// Default Value: json
    /// </summary>
    public sealed partial class SamSegmentationRequestMaskInputFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}