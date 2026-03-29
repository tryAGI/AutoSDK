//HintName: G.Models.RTCIceServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RTCIceServer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Urls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RTCIceServer" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="username"></param>
        /// <param name="credential"></param>
        public RTCIceServer(
            global::System.Collections.Generic.IList<string> urls,
            string? username,
            string? credential)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Username = username;
            this.Credential = credential;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RTCIceServer" /> class.
        /// </summary>
        public RTCIceServer()
        {
        }
    }
}