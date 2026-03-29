//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigManageConnections.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Manage connections configuration
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigManageConnections
    {
        /// <summary>
        /// Whether to enable the connection manager for automatic connection handling<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Custom callback URL for connected account auth flows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Enable the COMPOSIO_WAIT_FOR_CONNECTIONS tool for polling connection status. Default false. May not work reliably with GPT models.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_wait_for_connections")]
        public bool? EnableWaitForConnections { get; set; }

        /// <summary>
        /// Enable the "remove" action in COMPOSIO_MANAGE_CONNECTIONS. Default true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_connection_removal")]
        public bool? EnableConnectionRemoval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigManageConnections" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigManageConnections(
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
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigManageConnections" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigManageConnections()
        {
        }
    }
}