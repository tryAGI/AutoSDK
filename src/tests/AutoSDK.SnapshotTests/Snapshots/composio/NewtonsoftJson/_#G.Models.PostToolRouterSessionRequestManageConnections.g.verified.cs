//HintName: G.Models.PostToolRouterSessionRequestManageConnections.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for connection management settings<br/>
    /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestManageConnections
    {
        /// <summary>
        /// Whether to enable the connection manager for automatic connection handling. If true, we will provide a tool your agent can use to initiate connections to toolkits if it doesnt exist. If set to false, then you have to manage connections manually.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// The URL to redirect to after a user completes authentication for a connected account. This allows you to handle the auth callback in your own application.<br/>
        /// Example: https://your-app.com/auth/callback
        /// </summary>
        /// <example>https://your-app.com/auth/callback</example>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// When true, the COMPOSIO_WAIT_FOR_CONNECTIONS tool is available for agents to poll connection status after sharing auth URLs. Default is false (disabled). May not work reliably with GPT models.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("enable_wait_for_connections")]
        public bool? EnableWaitForConnections { get; set; }

        /// <summary>
        /// Enable the "remove" action in COMPOSIO_MANAGE_CONNECTIONS to allow deleting connected accounts. Default true.<br/>
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
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestManageConnections" /> class.
        /// </summary>
        /// <param name="enable">
        /// Whether to enable the connection manager for automatic connection handling. If true, we will provide a tool your agent can use to initiate connections to toolkits if it doesnt exist. If set to false, then you have to manage connections manually.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="callbackUrl">
        /// The URL to redirect to after a user completes authentication for a connected account. This allows you to handle the auth callback in your own application.<br/>
        /// Example: https://your-app.com/auth/callback
        /// </param>
        /// <param name="enableWaitForConnections">
        /// When true, the COMPOSIO_WAIT_FOR_CONNECTIONS tool is available for agents to poll connection status after sharing auth URLs. Default is false (disabled). May not work reliably with GPT models.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="enableConnectionRemoval">
        /// Enable the "remove" action in COMPOSIO_MANAGE_CONNECTIONS to allow deleting connected accounts. Default true.<br/>
        /// Default Value: true
        /// </param>
        public PostToolRouterSessionRequestManageConnections(
            bool? enable,
            string? callbackUrl,
            bool? enableWaitForConnections,
            bool? enableConnectionRemoval)
        {
            this.Enable = enable;
            this.CallbackUrl = callbackUrl;
            this.EnableWaitForConnections = enableWaitForConnections;
            this.EnableConnectionRemoval = enableConnectionRemoval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestManageConnections" /> class.
        /// </summary>
        public PostToolRouterSessionRequestManageConnections()
        {
        }
    }
}