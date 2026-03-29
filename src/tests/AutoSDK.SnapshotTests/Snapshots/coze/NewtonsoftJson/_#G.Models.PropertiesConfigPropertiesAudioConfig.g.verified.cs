//HintName: G.Models.PropertiesConfigPropertiesAudioConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 房间音频配置
    /// </summary>
    public sealed partial class PropertiesConfigPropertiesAudioConfig
    {
        /// <summary>
        /// 房间音频编码格式，AACLC / G711A / OPUS / G722
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codec")]
        public string? Codec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesAudioConfig" /> class.
        /// </summary>
        /// <param name="codec">
        /// 房间音频编码格式，AACLC / G711A / OPUS / G722
        /// </param>
        public PropertiesConfigPropertiesAudioConfig(
            string? codec)
        {
            this.Codec = codec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesAudioConfig" /> class.
        /// </summary>
        public PropertiesConfigPropertiesAudioConfig()
        {
        }
    }
}