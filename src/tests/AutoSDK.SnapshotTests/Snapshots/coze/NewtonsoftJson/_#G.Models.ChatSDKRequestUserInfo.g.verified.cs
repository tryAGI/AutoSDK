//HintName: G.Models.ChatSDKRequestUserInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nickname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUserInfo" /> class.
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="url"></param>
        /// <param name="id"></param>
        public ChatSDKRequestUserInfo(
            string nickname,
            string url,
            string? id)
        {
            this.Id = id;
            this.Nickname = nickname ?? throw new global::System.ArgumentNullException(nameof(nickname));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUserInfo" /> class.
        /// </summary>
        public ChatSDKRequestUserInfo()
        {
        }
    }
}