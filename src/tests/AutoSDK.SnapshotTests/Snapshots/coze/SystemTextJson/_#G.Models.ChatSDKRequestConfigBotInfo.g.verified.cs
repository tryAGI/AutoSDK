//HintName: G.Models.ChatSDKRequestConfigBotInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestConfigBotInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfigBotInfo" /> class.
        /// </summary>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestConfigBotInfo(
            object? parameters)
        {
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfigBotInfo" /> class.
        /// </summary>
        public ChatSDKRequestConfigBotInfo()
        {
        }
    }
}