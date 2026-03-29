//HintName: G.Models.PropertiesConfigPropertiesTurnDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 语音检测配置
    /// </summary>
    public sealed partial class PropertiesConfigPropertiesTurnDetection
    {
        /// <summary>
        /// 语音检测类型，支持 server_vad / client_vad / client_interrupt，默认 server_vad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeJsonConverter))]
        public global::G.PropertiesConfigPropertiesTurnDetectionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesTurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// 语音检测类型，支持 server_vad / client_vad / client_interrupt，默认 server_vad
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesConfigPropertiesTurnDetection(
            global::G.PropertiesConfigPropertiesTurnDetectionType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesTurnDetection" /> class.
        /// </summary>
        public PropertiesConfigPropertiesTurnDetection()
        {
        }
    }
}