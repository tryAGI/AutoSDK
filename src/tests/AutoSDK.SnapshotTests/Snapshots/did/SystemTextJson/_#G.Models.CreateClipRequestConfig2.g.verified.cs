//HintName: G.Models.CreateClipRequestConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateClipRequestConfig2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public global::G.CreateClipRequestConfigLogo2? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipRequestConfigResultFormat2JsonConverter))]
        public global::G.CreateClipRequestConfigResultFormat2? ResultFormat { get; set; }

        /// <summary>
        /// The output resolution sets the maximum height or width of the output video.<br/>
        /// The aspect ratio is preserved from the source image.<br/>
        /// Example: 1080
        /// </summary>
        /// <example>1080</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_resolution")]
        public double? OutputResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestConfig2" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipRequestConfig2(
            global::G.CreateClipRequestConfigLogo2? logo,
            global::G.CreateClipRequestConfigResultFormat2? resultFormat,
            double? outputResolution)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
            this.OutputResolution = outputResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestConfig2" /> class.
        /// </summary>
        public CreateClipRequestConfig2()
        {
        }
    }
}