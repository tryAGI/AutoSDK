//HintName: G.Models.PostConnectedAccountsResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponse
    {
        /// <summary>
        /// The id of the connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The connection data of the connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionData")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostConnectedAccountsResponseConnectionDataVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant6, global::G.PostConnectedAccountsResponseConnectionDataVariant7, global::G.PostConnectedAccountsResponseConnectionDataVariant8, global::G.PostConnectedAccountsResponseConnectionDataVariant9, global::G.PostConnectedAccountsResponseConnectionDataVariant10, global::G.PostConnectedAccountsResponseConnectionDataVariant11, global::G.PostConnectedAccountsResponseConnectionDataVariant12, global::G.PostConnectedAccountsResponseConnectionDataVariant13, global::G.PostConnectedAccountsResponseConnectionDataVariant14>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant6, global::G.PostConnectedAccountsResponseConnectionDataVariant7, global::G.PostConnectedAccountsResponseConnectionDataVariant8, global::G.PostConnectedAccountsResponseConnectionDataVariant9, global::G.PostConnectedAccountsResponseConnectionDataVariant10, global::G.PostConnectedAccountsResponseConnectionDataVariant11, global::G.PostConnectedAccountsResponseConnectionDataVariant12, global::G.PostConnectedAccountsResponseConnectionDataVariant13, global::G.PostConnectedAccountsResponseConnectionDataVariant14> ConnectionData { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostConnectedAccountsResponseStatus Status { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version. Please use id and auth_config.id instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostConnectedAccountsResponseDeprecated Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the connected account
        /// </param>
        /// <param name="connectionData">
        /// The connection data of the connected account
        /// </param>
        /// <param name="status">
        /// DEPRECATED: This field will be removed in a future version
        /// </param>
        /// <param name="deprecated">
        /// DEPRECATED: This field will be removed in a future version. Please use id and auth_config.id instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponse(
            string id,
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant6, global::G.PostConnectedAccountsResponseConnectionDataVariant7, global::G.PostConnectedAccountsResponseConnectionDataVariant8, global::G.PostConnectedAccountsResponseConnectionDataVariant9, global::G.PostConnectedAccountsResponseConnectionDataVariant10, global::G.PostConnectedAccountsResponseConnectionDataVariant11, global::G.PostConnectedAccountsResponseConnectionDataVariant12, global::G.PostConnectedAccountsResponseConnectionDataVariant13, global::G.PostConnectedAccountsResponseConnectionDataVariant14> connectionData,
            global::G.PostConnectedAccountsResponseStatus status,
            global::G.PostConnectedAccountsResponseDeprecated deprecated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectionData = connectionData;
            this.Status = status;
            this.Deprecated = deprecated ?? throw new global::System.ArgumentNullException(nameof(deprecated));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponse" /> class.
        /// </summary>
        public PostConnectedAccountsResponse()
        {
        }
    }
}