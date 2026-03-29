//HintName: G.Models.GetClipsResponseClipConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration that used to process the clip
    /// </summary>
    public sealed partial class GetClipsResponseClipConfig2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.GetClipsResponseClipConfigLogo2? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        public global::G.GetClipsResponseClipConfigResultFormat2? ResultFormat { get; set; }

        /// <summary>
        /// The output resolution sets the maximum height or width of the output video.<br/>
        /// The aspect ratio is preserved from the source image.<br/>
        /// Example: 1080
        /// </summary>
        /// <example>1080</example>
        [global::Newtonsoft.Json.JsonProperty("output_resolution")]
        public double? OutputResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponseClipConfig2" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="resultFormat">
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution sets the maximum height or width of the output video.<br/>
        /// The aspect ratio is preserved from the source image.<br/>
        /// Example: 1080
        /// </param>
        public GetClipsResponseClipConfig2(
            global::G.GetClipsResponseClipConfigLogo2? logo,
            global::G.GetClipsResponseClipConfigResultFormat2? resultFormat,
            double? outputResolution)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
            this.OutputResolution = outputResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponseClipConfig2" /> class.
        /// </summary>
        public GetClipsResponseClipConfig2()
        {
        }
    }
}