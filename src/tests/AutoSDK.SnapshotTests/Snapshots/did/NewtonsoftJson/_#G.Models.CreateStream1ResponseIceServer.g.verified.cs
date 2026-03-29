//HintName: G.Models.CreateStream1ResponseIceServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStream1ResponseIceServer
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
        /// Initializes a new instance of the <see cref="CreateStream1ResponseIceServer" /> class.
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
        public CreateStream1ResponseIceServer(
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> urls,
            string? username,
            string? credential)
        {
            this.Urls = urls;
            this.Username = username;
            this.Credential = credential;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStream1ResponseIceServer" /> class.
        /// </summary>
        public CreateStream1ResponseIceServer()
        {
        }
    }
}