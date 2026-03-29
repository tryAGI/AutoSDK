//HintName: G.Models.CreateClipStreamRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateClipStreamRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.AnyOf<global::G.CreateClipStreamRequestConfigLogo, bool?>? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        public global::G.CreateClipStreamRequestConfigResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestConfig" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="resultFormat">
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </param>
        public CreateClipStreamRequestConfig(
            global::G.AnyOf<global::G.CreateClipStreamRequestConfigLogo, bool?>? logo,
            global::G.CreateClipStreamRequestConfigResultFormat? resultFormat)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestConfig" /> class.
        /// </summary>
        public CreateClipStreamRequestConfig()
        {
        }
    }
}