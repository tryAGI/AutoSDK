//HintName: G.Models.SamSegmentationRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the response. Must be one of json or binary. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons, then returned as json.<br/>
    /// Default Value: json
    /// </summary>
    public sealed partial class SamSegmentationRequestFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}