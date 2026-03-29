//HintName: G.Models.Sam2SegmentationPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM segmentation prediction.<br/>
    /// Attributes:<br/>
    ///     masks (Union[List[List[List[int]]], Dict[str, Any], Any]): Mask data - either polygon coordinates or RLE encoding.<br/>
    ///     confidence (float): Masks confidences.<br/>
    ///     format (Optional[str]): Format of the mask data: 'polygon' or 'rle'.
    /// </summary>
    public sealed partial class Sam2SegmentationPrediction
    {
        /// <summary>
        /// If polygon format, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If rle format, masks is a dictionary with the keys 'size' and 'counts' containing the size and counts of the RLE encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> Masks { get; set; }

        /// <summary>
        /// Masks confidences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Format of the mask data: 'polygon' or 'rle'<br/>
        /// Default Value: polygon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationPrediction" /> class.
        /// </summary>
        /// <param name="masks">
        /// If polygon format, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If rle format, masks is a dictionary with the keys 'size' and 'counts' containing the size and counts of the RLE encoding.
        /// </param>
        /// <param name="confidence">
        /// Masks confidences
        /// </param>
        /// <param name="format">
        /// Format of the mask data: 'polygon' or 'rle'<br/>
        /// Default Value: polygon
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam2SegmentationPrediction(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> masks,
            double confidence,
            string? format)
        {
            this.Masks = masks;
            this.Confidence = confidence;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationPrediction" /> class.
        /// </summary>
        public Sam2SegmentationPrediction()
        {
        }
    }
}