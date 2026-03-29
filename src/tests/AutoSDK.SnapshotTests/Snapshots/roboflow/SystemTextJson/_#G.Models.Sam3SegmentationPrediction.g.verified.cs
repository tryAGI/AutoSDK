//HintName: G.Models.Sam3SegmentationPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3SegmentationPrediction
    {
        /// <summary>
        /// Mask data - either polygon coordinates or RLE encoding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> Masks { get; set; }

        /// <summary>
        /// Masks confidence
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
        /// Initializes a new instance of the <see cref="Sam3SegmentationPrediction" /> class.
        /// </summary>
        /// <param name="masks">
        /// Mask data - either polygon coordinates or RLE encoding
        /// </param>
        /// <param name="confidence">
        /// Masks confidence
        /// </param>
        /// <param name="format">
        /// Format of the mask data: 'polygon' or 'rle'<br/>
        /// Default Value: polygon
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam3SegmentationPrediction(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> masks,
            double confidence,
            string? format)
        {
            this.Masks = masks;
            this.Confidence = confidence;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationPrediction" /> class.
        /// </summary>
        public Sam3SegmentationPrediction()
        {
        }
    }
}