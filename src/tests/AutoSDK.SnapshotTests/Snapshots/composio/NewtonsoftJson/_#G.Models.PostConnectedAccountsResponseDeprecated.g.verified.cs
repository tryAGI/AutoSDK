//HintName: G.Models.PostConnectedAccountsResponseDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: This field will be removed in a future version. Please use id and auth_config.id instead.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class PostConnectedAccountsResponseDeprecated
    {
        /// <summary>
        /// The uuid of the connected account
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// The uuid of the auth config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authConfigUuid", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid AuthConfigUuid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseDeprecated" /> class.
        /// </summary>
        /// <param name="uuid">
        /// The uuid of the connected account
        /// </param>
        /// <param name="authConfigUuid">
        /// The uuid of the auth config
        /// </param>
        public PostConnectedAccountsResponseDeprecated(
            global::System.Guid uuid,
            global::System.Guid authConfigUuid)
        {
            this.Uuid = uuid;
            this.AuthConfigUuid = authConfigUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseDeprecated" /> class.
        /// </summary>
        public PostConnectedAccountsResponseDeprecated()
        {
        }
    }
}