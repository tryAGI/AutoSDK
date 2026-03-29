//HintName: G.Models.ChatSDKRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSDKRequestConfigAppInfo AppInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botInfo")]
        public global::G.ChatSDKRequestConfigBotInfo? BotInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isIframe")]
        public bool? IsIframe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatSDKRequestConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSDKRequestConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfig" /> class.
        /// </summary>
        /// <param name="appInfo"></param>
        /// <param name="botId"></param>
        /// <param name="type"></param>
        /// <param name="botInfo"></param>
        /// <param name="isIframe"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestConfig(
            global::G.ChatSDKRequestConfigAppInfo appInfo,
            string botId,
            global::G.ChatSDKRequestConfigType type,
            global::G.ChatSDKRequestConfigBotInfo? botInfo,
            bool? isIframe)
        {
            this.AppInfo = appInfo ?? throw new global::System.ArgumentNullException(nameof(appInfo));
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.BotInfo = botInfo;
            this.IsIframe = isIframe;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfig" /> class.
        /// </summary>
        public ChatSDKRequestConfig()
        {
        }
    }
}