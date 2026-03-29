//HintName: G.Models.PropertiesConfigPropertiesTranslateConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 同传配置，仅在房间模式为同传时生效
    /// </summary>
    public sealed partial class PropertiesConfigPropertiesTranslateConfig
    {
        /// <summary>
        /// 翻译源语言
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// 翻译目标语言
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesTranslateConfig" /> class.
        /// </summary>
        /// <param name="from">
        /// 翻译源语言
        /// </param>
        /// <param name="to">
        /// 翻译目标语言
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesConfigPropertiesTranslateConfig(
            string? from,
            string? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesTranslateConfig" /> class.
        /// </summary>
        public PropertiesConfigPropertiesTranslateConfig()
        {
        }
    }
}