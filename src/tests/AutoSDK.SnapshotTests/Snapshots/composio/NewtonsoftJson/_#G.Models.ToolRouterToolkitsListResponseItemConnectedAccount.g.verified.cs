//HintName: G.Models.ToolRouterToolkitsListResponseItemConnectedAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Connected account if available
    /// </summary>
    public sealed partial class ToolRouterToolkitsListResponseItemConnectedAccount
    {
        /// <summary>
        /// Connected account identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// User identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Connection status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Auth config details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig AuthConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemConnectedAccount" /> class.
        /// </summary>
        /// <param name="id">
        /// Connected account identifier
        /// </param>
        /// <param name="userId">
        /// User identifier
        /// </param>
        /// <param name="status">
        /// Connection status
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="authConfig">
        /// Auth config details
        /// </param>
        public ToolRouterToolkitsListResponseItemConnectedAccount(
            string id,
            string userId,
            string status,
            global::System.DateTime createdAt,
            global::G.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig authConfig)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemConnectedAccount" /> class.
        /// </summary>
        public ToolRouterToolkitsListResponseItemConnectedAccount()
        {
        }
    }
}