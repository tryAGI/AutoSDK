//HintName: G.Models.ChatSDKRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.ChatSDKRequestAuth? Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSDKRequestConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ui", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSDKRequestUi Ui { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSDKRequestUserInfo UserInfo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequest" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ui"></param>
        /// <param name="userInfo"></param>
        /// <param name="auth"></param>
        public ChatSDKRequest(
            global::G.ChatSDKRequestConfig config,
            global::G.ChatSDKRequestUi ui,
            global::G.ChatSDKRequestUserInfo userInfo,
            global::G.ChatSDKRequestAuth? auth)
        {
            this.Auth = auth;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Ui = ui ?? throw new global::System.ArgumentNullException(nameof(ui));
            this.UserInfo = userInfo ?? throw new global::System.ArgumentNullException(nameof(userInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequest" /> class.
        /// </summary>
        public ChatSDKRequest()
        {
        }
    }
}