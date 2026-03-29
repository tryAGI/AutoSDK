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
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant6, global::G.PostConnectedAccountsRequestConnectionStateVariant7, global::G.PostConnectedAccountsRequestConnectionStateVariant8, global::G.PostConnectedAccountsRequestConnectionStateVariant9, global::G.PostConnectedAccountsRequestConnectionStateVariant10, global::G.PostConnectedAccountsRequestConnectionStateVariant11, global::G.PostConnectedAccountsRequestConnectionStateVariant12, global::G.PostConnectedAccountsRequestConnectionStateVariant13, global::G.PostConnectedAccountsRequestConnectionStateVariant14>? State { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use state instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Data { get; set; }

        /// <summary>
        /// The user id of the connected account<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The URL to redirect to after connection completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use callback_url instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_uri")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated_is_v1_rerouted")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DeprecatedIsV1Rerouted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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