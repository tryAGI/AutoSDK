//HintName: G.Models.PropertiesMediaConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesMediaConfig
    {
        /// <summary>
        /// 是否关闭语音通话，true:关闭 false:开启  默认为false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_voice_call_closed")]
        public bool? IsVoiceCallClosed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesMediaConfig" /> class.
        /// </summary>
        /// <param name="isVoiceCallClosed">
        /// 是否关闭语音通话，true:关闭 false:开启  默认为false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesMediaConfig(
            bool? isVoiceCallClosed)
        {
            this.IsVoiceCallClosed = isVoiceCallClosed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesMediaConfig" /> class.
        /// </summary>
        public PropertiesMediaConfig()
        {
        }
    }
}