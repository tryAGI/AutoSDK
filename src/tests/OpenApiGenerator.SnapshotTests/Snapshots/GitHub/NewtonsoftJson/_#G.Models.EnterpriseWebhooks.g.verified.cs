//HintName: G.Models.EnterpriseWebhooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured
    /// on an enterprise account or an organization that's part of an enterprise account. For more information,
    /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
    /// </summary>
    public sealed partial class EnterpriseWebhooks
    {
        /// <summary>
        /// A short description of the enterprise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/enterprises/octo-business
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The enterprise's website URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// Unique identifier of the enterprise
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the enterprise.
        /// <br/>Example: Octo Business
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The slug url identifier for the enterprise.
        /// <br/>Example: octo-business
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}