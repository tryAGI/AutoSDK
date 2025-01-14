﻿//HintName: G.Models.AppsCreateFromManifestResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsCreateFromManifestResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string? WebhookSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pem", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pem { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCreateFromManifestResponse2" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="webhookSecret"></param>
        /// <param name="pem"></param>
        public AppsCreateFromManifestResponse2(
            string clientId,
            string clientSecret,
            string? webhookSecret,
            string pem)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.WebhookSecret = webhookSecret ?? throw new global::System.ArgumentNullException(nameof(webhookSecret));
            this.Pem = pem ?? throw new global::System.ArgumentNullException(nameof(pem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCreateFromManifestResponse2" /> class.
        /// </summary>
        public AppsCreateFromManifestResponse2()
        {
        }
    }
}