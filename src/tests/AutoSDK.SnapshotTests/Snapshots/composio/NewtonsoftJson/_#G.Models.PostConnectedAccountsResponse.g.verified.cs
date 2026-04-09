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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The connection data of the connected account
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionData", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant6, global::G.PostConnectedAccountsResponseConnectionDataVariant7, global::G.PostConnectedAccountsResponseConnectionDataVariant8, global::G.PostConnectedAccountsResponseConnectionDataVariant9, global::G.PostConnectedAccountsResponseConnectionDataVariant10, global::G.PostConnectedAccountsResponseConnectionDataVariant11, global::G.PostConnectedAccountsResponseConnectionDataVariant12, global::G.PostConnectedAccountsResponseConnectionDataVariant13, global::G.PostConnectedAccountsResponseConnectionDataVariant14> ConnectionData { get; set; } = default!;

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsResponseStatusJsonConverter))]
        public global::G.PostConnectedAccountsResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_uri")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version. Please use id and auth_config.id instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostConnectedAccountsResponseDeprecated Deprecated { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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