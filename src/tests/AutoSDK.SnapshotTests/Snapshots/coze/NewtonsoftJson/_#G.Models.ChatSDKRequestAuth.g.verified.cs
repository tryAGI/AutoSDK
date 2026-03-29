//HintName: G.Models.ChatSDKRequestAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestAuth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onRefreshToken")]
        public string? OnRefreshToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestAuth" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="onRefreshToken"></param>
        /// <param name="token"></param>
        public ChatSDKRequestAuth(
            string type,
            string? onRefreshToken,
            string? token)
        {
            this.OnRefreshToken = onRefreshToken;
            this.Token = token;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestAuth" /> class.
        /// </summary>
        public ChatSDKRequestAuth()
        {
        }
    }
}