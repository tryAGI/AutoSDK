//HintName: G.Models.WebRTCTURNConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebRTCTURNConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls", Required = global::Newtonsoft.Json.Required.Always)]
        public string Urls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credential", Required = global::Newtonsoft.Json.Required.Always)]
        public string Credential { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCTURNConfig" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="username"></param>
        /// <param name="credential"></param>
        public WebRTCTURNConfig(
            string urls,
            string username,
            string credential)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Credential = credential ?? throw new global::System.ArgumentNullException(nameof(credential));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCTURNConfig" /> class.
        /// </summary>
        public WebRTCTURNConfig()
        {
        }
    }
}