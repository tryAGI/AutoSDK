//HintName: G.Models.CreateTalkStreamRequestConfigVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class CreateTalkStreamRequestConfigVariant12
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormat2JsonConverter))]
        public global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2? ResultFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequestConfigVariant12" /> class.
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
        public CreateTalkStreamRequestConfigVariant12(
            bool? stitch,
            global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2? resultFormat,
            bool? fluent,
            double? padAudio)
        {
            this.Stitch = stitch;
            this.ResultFormat = resultFormat;
            this.Fluent = fluent;
            this.PadAudio = padAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequestConfigVariant12" /> class.
        /// </summary>
        public CreateTalkStreamRequestConfigVariant12()
        {
        }
    }
}