﻿//HintName: G.Models.WebhookGithubAppAuthorizationRevoked.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookGithubAppAuthorizationRevokedActionJsonConverter))]
        public global::G.WebhookGithubAppAuthorizationRevokedAction Action { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookGithubAppAuthorizationRevoked(
            global::G.SimpleUser sender,
            global::G.WebhookGithubAppAuthorizationRevokedAction action)
        {
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        public WebhookGithubAppAuthorizationRevoked()
        {
        }
    }
}