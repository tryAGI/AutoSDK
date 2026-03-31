//HintName: G.Models.OmitTalksConfigLogoOrDriverExpressions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class OmitTalksConfigLogoOrDriverExpressions
    {
        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// File format of the animated result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OmitTalksConfigLogoOrDriverExpressionsResultFormatJsonConverter))]
        public global::G.OmitTalksConfigLogoOrDriverExpressionsResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Interpolate between the last &amp; first frames of the driver video<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fluent")]
        public bool? Fluent { get; set; }

        /// <summary>
        /// Pad the audio with silence at the end (given in seconds)<br/>
        /// Will increase the video duration &amp; the credits it consumes<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pad_audio")]
        public double? PadAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitTalksConfigLogoOrDriverExpressions" /> class.
        /// </summary>
        /// <param name="stitch">
        /// Stitch back the animated result to the original image
        /// </param>
        /// <param name="resultFormat">
        /// File format of the animated result
        /// </param>
        /// <param name="fluent">
        /// Interpolate between the last &amp; first frames of the driver video<br/>
        /// Default Value: false
        /// </param>
        /// <param name="padAudio">
        /// Pad the audio with silence at the end (given in seconds)<br/>
        /// Will increase the video duration &amp; the credits it consumes<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OmitTalksConfigLogoOrDriverExpressions(
            bool? stitch,
            global::G.OmitTalksConfigLogoOrDriverExpressionsResultFormat? resultFormat,
            bool? fluent,
            double? padAudio)
        {
            this.Stitch = stitch;
            this.ResultFormat = resultFormat;
            this.Fluent = fluent;
            this.PadAudio = padAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitTalksConfigLogoOrDriverExpressions" /> class.
        /// </summary>
        public OmitTalksConfigLogoOrDriverExpressions()
        {
        }
    }
}