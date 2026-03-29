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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Toolkit { get; set; }

        /// <summary>
        /// Description of what the toolkit does and its capabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether an active connection exists for this toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_active_connection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasActiveConnection { get; set; }

        /// <summary>
        /// Connection details including auth config and connected account IDs. Only present when has_active_connection is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_details")]
        public global::System.Collections.Generic.Dictionary<string, object?>? ConnectionDetails { get; set; }

        /// <summary>
        /// Information about the currently connected user (email, name, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_info")]
        public global::System.Collections.Generic.Dictionary<string, object?>? CurrentUserInfo { get; set; }

        /// <summary>
        /// List of connected accounts for this toolkit. Present when multi-account is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? Accounts { get; set; }

        /// <summary>
        /// When "required", the agent must specify which account to use. Present only when multiple accounts exist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionJsonConverter))]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection? AccountSelection { get; set; }

        /// <summary>
        /// Human-readable message about the connection status and next steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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