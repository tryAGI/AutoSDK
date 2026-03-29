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
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::G.ChatSDKRequestAuth? Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSDKRequestConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSDKRequestUi Ui { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSDKRequestUserInfo UserInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequest" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ui"></param>
        /// <param name="userInfo"></param>
        /// <param name="auth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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