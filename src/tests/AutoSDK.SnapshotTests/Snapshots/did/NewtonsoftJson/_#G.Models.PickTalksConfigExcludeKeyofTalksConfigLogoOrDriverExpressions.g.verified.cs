//HintName: G.Models.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions
    {
        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// File format of the animated result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormatJsonConverter))]
        public global::G.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Interpolate between the last &amp; first frames of the driver video<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fluent")]
        public bool? Fluent { get; set; }

        /// <summary>
        /// Pad the audio with silence at the end (given in seconds)<br/>
        /// Will increase the video duration &amp; the credits it consumes<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pad_audio")]
        public double? PadAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions" /> class.
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
        public PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions(
            bool? stitch,
            global::G.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat? resultFormat,
            bool? fluent,
            double? padAudio)
        {
            this.Stitch = stitch;
            this.ResultFormat = resultFormat;
            this.Fluent = fluent;
            this.PadAudio = padAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions" /> class.
        /// </summary>
        public PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions()
        {
        }
    }
}