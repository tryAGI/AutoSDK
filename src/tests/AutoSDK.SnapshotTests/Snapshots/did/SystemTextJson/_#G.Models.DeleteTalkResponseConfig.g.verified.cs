//HintName: G.Models.DeleteTalkResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration that used to process the talk
    /// </summary>
    public sealed partial class DeleteTalkResponseConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public global::G.DeleteTalkResponseConfigLogo? Logo { get; set; }

        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// File format of the animated result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteTalkResponseConfigResultFormatJsonConverter))]
        public global::G.DeleteTalkResponseConfigResultFormat? ResultFormat { get; set; }

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
        /// timed expressions for animation, the current expression is not cleared until a new expression is defined.<br/>
        /// Possible expressions include `happy`, `neutral` and more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_expressions")]
        public global::G.DeleteTalkResponseConfigDriverExpressions? DriverExpressions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTalkResponseConfig" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTalkResponseConfig(
            global::G.DeleteTalkResponseConfigLogo? logo,
            bool? stitch,
            global::G.DeleteTalkResponseConfigResultFormat? resultFormat,
            bool? fluent,
            double? padAudio,
            global::G.DeleteTalkResponseConfigDriverExpressions? driverExpressions)
        {
            this.Logo = logo;
            this.Stitch = stitch;
            this.ResultFormat = resultFormat;
            this.Fluent = fluent;
            this.PadAudio = padAudio;
            this.DriverExpressions = driverExpressions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTalkResponseConfig" /> class.
        /// </summary>
        public DeleteTalkResponseConfig()
        {
        }
    }
}