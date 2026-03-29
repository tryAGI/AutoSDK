//HintName: G.Models.PostConnectedAccountsRequestConnection.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnection
    {
        /// <summary>
        /// The state of the connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostConnectedAccountsRequestConnectionStateVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant6, global::G.PostConnectedAccountsRequestConnectionStateVariant7, global::G.PostConnectedAccountsRequestConnectionStateVariant8, global::G.PostConnectedAccountsRequestConnectionStateVariant9, global::G.PostConnectedAccountsRequestConnectionStateVariant10, global::G.PostConnectedAccountsRequestConnectionStateVariant11, global::G.PostConnectedAccountsRequestConnectionStateVariant12, global::G.PostConnectedAccountsRequestConnectionStateVariant13, global::G.PostConnectedAccountsRequestConnectionStateVariant14>))]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant6, global::G.PostConnectedAccountsRequestConnectionStateVariant7, global::G.PostConnectedAccountsRequestConnectionStateVariant8, global::G.PostConnectedAccountsRequestConnectionStateVariant9, global::G.PostConnectedAccountsRequestConnectionStateVariant10, global::G.PostConnectedAccountsRequestConnectionStateVariant11, global::G.PostConnectedAccountsRequestConnectionStateVariant12, global::G.PostConnectedAccountsRequestConnectionStateVariant13, global::G.PostConnectedAccountsRequestConnectionStateVariant14>? State { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use state instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Data { get; set; }

        /// <summary>
        /// The user id of the connected account<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The URL to redirect to after connection completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use callback_url instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated_is_v1_rerouted")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DeprecatedIsV1Rerouted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnection" /> class.
        /// </summary>
        /// <param name="state">
        /// The state of the connected account
        /// </param>
        /// <param name="userId">
        /// The user id of the connected account<br/>
        /// Default Value: default
        /// </param>
        /// <param name="callbackUrl">
        /// The URL to redirect to after connection completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnection(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant6, global::G.PostConnectedAccountsRequestConnectionStateVariant7, global::G.PostConnectedAccountsRequestConnectionStateVariant8, global::G.PostConnectedAccountsRequestConnectionStateVariant9, global::G.PostConnectedAccountsRequestConnectionStateVariant10, global::G.PostConnectedAccountsRequestConnectionStateVariant11, global::G.PostConnectedAccountsRequestConnectionStateVariant12, global::G.PostConnectedAccountsRequestConnectionStateVariant13, global::G.PostConnectedAccountsRequestConnectionStateVariant14>? state,
            string? userId,
            string? callbackUrl)
        {
            this.State = state;
            this.UserId = userId;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnection" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnection()
        {
        }
    }
}