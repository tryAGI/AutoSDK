//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse
    {
        /// <summary>
        /// The toolkit slug identifier (e.g., "gmail", "slack")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Toolkit { get; set; } = default!;

        /// <summary>
        /// Description of what the toolkit does and its capabilities
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Whether an active connection exists for this toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_active_connection", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasActiveConnection { get; set; } = default!;

        /// <summary>
        /// Connection details including auth config and connected account IDs. Only present when has_active_connection is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connection_details")]
        public global::System.Collections.Generic.Dictionary<string, object?>? ConnectionDetails { get; set; }

        /// <summary>
        /// Information about the currently connected user (email, name, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_info")]
        public global::System.Collections.Generic.Dictionary<string, object?>? CurrentUserInfo { get; set; }

        /// <summary>
        /// List of connected accounts for this toolkit. Present when multi-account is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accounts")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? Accounts { get; set; }

        /// <summary>
        /// When "required", the agent must specify which account to use. Present only when multiple accounts exist.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_selection")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionJsonConverter))]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection? AccountSelection { get; set; }

        /// <summary>
        /// Human-readable message about the connection status and next steps
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse" /> class.
        /// </summary>
        /// <param name="toolkit">
        /// The toolkit slug identifier (e.g., "gmail", "slack")
        /// </param>
        /// <param name="description">
        /// Description of what the toolkit does and its capabilities
        /// </param>
        /// <param name="hasActiveConnection">
        /// Whether an active connection exists for this toolkit
        /// </param>
        /// <param name="statusMessage">
        /// Human-readable message about the connection status and next steps
        /// </param>
        /// <param name="connectionDetails">
        /// Connection details including auth config and connected account IDs. Only present when has_active_connection is true.
        /// </param>
        /// <param name="currentUserInfo">
        /// Information about the currently connected user (email, name, etc.)
        /// </param>
        /// <param name="accounts">
        /// List of connected accounts for this toolkit. Present when multi-account is enabled.
        /// </param>
        /// <param name="accountSelection">
        /// When "required", the agent must specify which account to use. Present only when multiple accounts exist.
        /// </param>
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse(
            string toolkit,
            string description,
            bool hasActiveConnection,
            string statusMessage,
            global::System.Collections.Generic.Dictionary<string, object?>? connectionDetails,
            global::System.Collections.Generic.Dictionary<string, object?>? currentUserInfo,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? accounts,
            global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection? accountSelection)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HasActiveConnection = hasActiveConnection;
            this.ConnectionDetails = connectionDetails;
            this.CurrentUserInfo = currentUserInfo;
            this.Accounts = accounts;
            this.AccountSelection = accountSelection;
            this.StatusMessage = statusMessage ?? throw new global::System.ArgumentNullException(nameof(statusMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse()
        {
        }
    }
}