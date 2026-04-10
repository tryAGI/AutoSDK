//HintName: G.Models.ClipStreamConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipStreamConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.AnyOf<global::G.ClipStreamConfigLogo, bool?>? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClipStreamConfigResultFormatJsonConverter))]
        public global::G.ClipStreamConfigResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipStreamConfig" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="resultFormat">
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </param>
        public ClipStreamConfig(
            global::G.AnyOf<global::G.ClipStreamConfigLogo, bool?>? logo,
            global::G.ClipStreamConfigResultFormat? resultFormat)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipStreamConfig" /> class.
        /// </summary>
        public ClipStreamConfig()
        {
        }
    }
}