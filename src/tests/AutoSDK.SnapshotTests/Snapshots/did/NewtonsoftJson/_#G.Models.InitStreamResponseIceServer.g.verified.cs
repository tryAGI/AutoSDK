//HintName: G.Models.InitStreamResponseIceServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitStreamResponseIceServer
    {
        /// <summary>
        /// URL of the server - can be multiple addresses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> Urls { get; set; } = default!;

        /// <summary>
        /// Username for authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Credintials for secure connection to the server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitStreamResponseIceServer" /> class.
        /// </summary>
        /// <param name="urls">
        /// URL of the server - can be multiple addresses
        /// </param>
        /// <param name="username">
        /// Username for authentication
        /// </param>
        /// <param name="credential">
        /// Credintials for secure connection to the server
        /// </param>
        public InitStreamResponseIceServer(
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> urls,
            string? username,
            string? credential)
        {
            this.Urls = urls;
            this.Username = username;
            this.Credential = credential;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitStreamResponseIceServer" /> class.
        /// </summary>
        public InitStreamResponseIceServer()
        {
        }
    }
}