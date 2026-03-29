//HintName: G.Models.GetConnectedAccountsResponseItemAuthConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemAuthConfig
    {
        /// <summary>
        /// The id of the auth config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// the authScheme is part of the connection state use it there
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_scheme", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetConnectedAccountsResponseItemAuthConfigAuthScheme AuthScheme { get; set; } = default!;

        /// <summary>
        /// Whether the auth config is managed by Composio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_composio_managed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsComposioManaged { get; set; } = default!;

        /// <summary>
        /// Whether the auth config is disabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDisabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetConnectedAccountsResponseItemAuthConfigDeprecated? Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemAuthConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the auth config
        /// </param>
        /// <param name="authScheme">
        /// the authScheme is part of the connection state use it there
        /// </param>
        /// <param name="isComposioManaged">
        /// Whether the auth config is managed by Composio
        /// </param>
        /// <param name="isDisabled">
        /// Whether the auth config is disabled
        /// </param>
        public GetConnectedAccountsResponseItemAuthConfig(
            string id,
            global::G.GetConnectedAccountsResponseItemAuthConfigAuthScheme authScheme,
            bool isComposioManaged,
            bool isDisabled)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AuthScheme = authScheme;
            this.IsComposioManaged = isComposioManaged;
            this.IsDisabled = isDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemAuthConfig" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemAuthConfig()
        {
        }
    }
}