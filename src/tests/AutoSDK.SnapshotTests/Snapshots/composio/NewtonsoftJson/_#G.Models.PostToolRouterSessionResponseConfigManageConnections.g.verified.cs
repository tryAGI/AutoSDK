//HintName: G.Models.PostToolRouterSessionResponseConfigManageConnections.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Manage connections configuration
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseConfigManageConnections
    {
        /// <summary>
        /// Whether to enable the connection manager for automatic connection handling<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Custom callback URL for connected account auth flows
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Enable the COMPOSIO_WAIT_FOR_CONNECTIONS tool for polling connection status. Default false. May not work reliably with GPT models.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_wait_for_connections")]
        public bool? EnableWaitForConnections { get; set; }

        /// <summary>
        /// Enable the "remove" action in COMPOSIO_MANAGE_CONNECTIONS. Default true.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_connection_removal")]
        public bool? EnableConnectionRemoval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigManageConnections" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to enable the connection manager for automatic connection handling<br/>
        /// Default Value: true
        /// </param>
        /// <param name="callbackUrl">
        /// Custom callback URL for connected account auth flows
        /// </param>
        /// <param name="enableWaitForConnections">
        /// Enable the COMPOSIO_WAIT_FOR_CONNECTIONS tool for polling connection status. Default false. May not work reliably with GPT models.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableConnectionRemoval">
        /// Enable the "remove" action in COMPOSIO_MANAGE_CONNECTIONS. Default true.<br/>
        /// Default Value: true
        /// </param>
        public PostToolRouterSessionResponseConfigManageConnections(
            bool? enabled,
            string? callbackUrl,
            bool? enableWaitForConnections,
            bool? enableConnectionRemoval)
        {
            this.Enabled = enabled;
            this.CallbackUrl = callbackUrl;
            this.EnableWaitForConnections = enableWaitForConnections;
            this.EnableConnectionRemoval = enableConnectionRemoval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigManageConnections" /> class.
        /// </summary>
        public PostToolRouterSessionResponseConfigManageConnections()
        {
        }
    }
}