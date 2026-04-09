//HintName: G.Models.CreateTalkRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options
    /// </summary>
    public sealed partial class CreateTalkRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.CreateTalkRequestConfigLogo? Logo { get; set; }

        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// File format of the animated result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTalkRequestConfigResultFormatJsonConverter))]
        public global::G.CreateTalkRequestConfigResultFormat? ResultFormat { get; set; }

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
        /// timed expressions for animation, the current expression is not cleared until a new expression is defined.<br/>
        /// Possible expressions include `happy`, `neutral` and more.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("driver_expressions")]
        public global::G.CreateTalkRequestConfigDriverExpressions? DriverExpressions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestConfig" /> class.
        /// </summary>
        /// <param name="logo"></param>
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
        /// <param name="driverExpressions">
        /// timed expressions for animation, the current expression is not cleared until a new expression is defined.<br/>
        /// Possible expressions include `happy`, `neutral` and more.
        /// </param>
        public CreateTalkRequestConfig(
            global::G.CreateTalkRequestConfigLogo? logo,
            bool? stitch,
            global::G.CreateTalkRequestConfigResultFormat? resultFormat,
            bool? fluent,
            double? padAudio,
            global::G.CreateTalkRequestConfigDriverExpressions? driverExpressions)
        {
            this.Logo = logo;
            this.Stitch = stitch;
            this.ResultFormat = resultFormat;
            this.Fluent = fluent;
            this.PadAudio = padAudio;
            this.DriverExpressions = driverExpressions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestConfig" /> class.
        /// </summary>
        public CreateTalkRequestConfig()
        {
        }
    }
}