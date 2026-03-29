//HintName: G.Models.GetConnectedAccountsByNanoidResponseAuthConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseAuthConfig
    {
        /// <summary>
        /// The id of the auth config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// the authScheme is part of the connection state use it there
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_scheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseAuthConfigAuthSchemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Whether the auth config is managed by Composio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_composio_managed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsComposioManaged { get; set; }

        /// <summary>
        /// Whether the auth config is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetConnectedAccountsByNanoidResponseAuthConfigDeprecated? Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseAuthConfig" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseAuthConfig(
            string id,
            global::G.GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme authScheme,
            bool isComposioManaged,
            bool isDisabled)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AuthScheme = authScheme;
            this.IsComposioManaged = isComposioManaged;
            this.IsDisabled = isDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseAuthConfig" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseAuthConfig()
        {
        }
    }
}