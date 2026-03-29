//HintName: G.Models.Sam2SegmentationRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the response. Must be one of 'json', 'rle', or 'binary'. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons. If rle, masks are converted to RLE format.<br/>
    /// Default Value: json
    /// </summary>
    public sealed partial class Sam2SegmentationRequestFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}