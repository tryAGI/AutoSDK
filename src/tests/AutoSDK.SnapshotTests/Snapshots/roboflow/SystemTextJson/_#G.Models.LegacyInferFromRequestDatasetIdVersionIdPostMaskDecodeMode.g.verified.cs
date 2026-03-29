//HintName: G.Models.LegacyInferFromRequestDatasetIdVersionIdPostMaskDecodeMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of 'accurate' or 'fast'. If 'accurate' the mask will be decoded using the original image size. If 'fast' the mask will be decoded using the original mask size. 'accurate' is slower but more accurate.<br/>
    /// Default Value: accurate
    /// </summary>
    public sealed partial class LegacyInferFromRequestDatasetIdVersionIdPostMaskDecodeMode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}