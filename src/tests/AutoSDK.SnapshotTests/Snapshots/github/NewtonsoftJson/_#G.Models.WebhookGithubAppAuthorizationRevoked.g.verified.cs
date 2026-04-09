//HintName: G.Models.WebhookGithubAppAuthorizationRevoked.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookGithubAppAuthorizationRevoked
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookGithubAppAuthorizationRevokedActionJsonConverter))]
        public global::G.WebhookGithubAppAuthorizationRevokedAction Action { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Sender { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
        public WebhookGithubAppAuthorizationRevoked(
            global::G.SimpleUser sender,
            global::G.WebhookGithubAppAuthorizationRevokedAction action)
        {
            this.Action = action;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        public WebhookGithubAppAuthorizationRevoked()
        {
        }
    }
}