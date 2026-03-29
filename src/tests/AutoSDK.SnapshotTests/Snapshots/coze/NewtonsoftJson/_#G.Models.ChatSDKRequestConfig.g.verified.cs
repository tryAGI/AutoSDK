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
        [global::Newtonsoft.Json.JsonProperty("appInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSDKRequestConfigAppInfo AppInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("botInfo")]
        public global::G.ChatSDKRequestConfigBotInfo? BotInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isIframe")]
        public bool? IsIframe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSDKRequestConfigType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfig" /> class.
        /// </summary>
        /// <param name="appInfo"></param>
        /// <param name="botId"></param>
        /// <param name="type"></param>
        /// <param name="botInfo"></param>
        /// <param name="isIframe"></param>
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