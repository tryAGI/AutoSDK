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
        [global::Newtonsoft.Json.JsonProperty("masks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> Masks { get; set; } = default!;

        /// <summary>
        /// Masks confidence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Format of the mask data: 'polygon' or 'rle'<br/>
        /// Default Value: polygon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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