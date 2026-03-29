//HintName: G.Models.CreateClipRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateClipRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.CreateClipRequestConfigLogo? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        public global::G.CreateClipRequestConfigResultFormat? ResultFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateClipRequestConfig" /> class.
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
        public CreateClipRequestConfig(
            global::G.CreateClipRequestConfigLogo? logo,
            global::G.CreateClipRequestConfigResultFormat? resultFormat,
            double? outputResolution)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
            this.OutputResolution = outputResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestConfig" /> class.
        /// </summary>
        public CreateClipRequestConfig()
        {
        }
    }
}