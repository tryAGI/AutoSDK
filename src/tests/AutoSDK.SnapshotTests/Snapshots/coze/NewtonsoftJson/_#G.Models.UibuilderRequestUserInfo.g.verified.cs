//HintName: G.Models.UibuilderRequestUserInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UibuilderRequestUserInfo
    {
        /// <summary>
        /// Example: user_123456
        /// </summary>
        /// <example>user_123456</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: 小明
        /// </summary>
        /// <example>小明</example>
        [global::Newtonsoft.Json.JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// Example: https://example.com/avatars/user123.png
        /// </summary>
        /// <example>https://example.com/avatars/user123.png</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UibuilderRequestUserInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: user_123456
        /// </param>
        /// <param name="nickname">
        /// Example: 小明
        /// </param>
        /// <param name="url">
        /// Example: https://example.com/avatars/user123.png
        /// </param>
        public UibuilderRequestUserInfo(
            string? id,
            string? nickname,
            string? url)
        {
            this.Id = id;
            this.Nickname = nickname;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UibuilderRequestUserInfo" /> class.
        /// </summary>
        public UibuilderRequestUserInfo()
        {
        }
    }
}