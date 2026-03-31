//HintName: G.Models.Create3RequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Create3RequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.Create3RequestConfigLogo, bool?>))]
        public global::G.AnyOf<global::G.Create3RequestConfigLogo, bool?>? Logo { get; set; }

        /// <summary>
        /// The file format of the result. If result_url is provided, result_format must match the format of the result_url.<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Create3RequestConfigResultFormatJsonConverter))]
        public global::G.Create3RequestConfigResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// The output resolution of the video (height in pixels, 16:9 aspect ratio).<br/>
        /// Allowed values: 480 (SD), 720 (HD), 1080 (Full HD).<br/>
        /// Default Value: 1080
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_resolution")]
        public double? OutputResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3RequestConfig" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="resultFormat">
        /// The file format of the result. If result_url is provided, result_format must match the format of the result_url.<br/>
        /// Example: mp4
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution of the video (height in pixels, 16:9 aspect ratio).<br/>
        /// Allowed values: 480 (SD), 720 (HD), 1080 (Full HD).<br/>
        /// Default Value: 1080
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Create3RequestConfig(
            global::G.AnyOf<global::G.Create3RequestConfigLogo, bool?>? logo,
            global::G.Create3RequestConfigResultFormat? resultFormat,
            double? outputResolution)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
            this.OutputResolution = outputResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3RequestConfig" /> class.
        /// </summary>
        public Create3RequestConfig()
        {
        }
    }
}