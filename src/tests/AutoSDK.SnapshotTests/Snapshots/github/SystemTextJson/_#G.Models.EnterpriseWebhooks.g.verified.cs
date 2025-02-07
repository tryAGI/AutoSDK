//HintName: G.Models.EnterpriseWebhooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
    /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
    /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
    /// </summary>
    public sealed partial class EnterpriseWebhooks
    {
        /// <summary>
        /// A short description of the enterprise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: https://github.com/enterprises/octo-business
        /// </summary>
        /// <example>https://github.com/enterprises/octo-business</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The enterprise's website URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// Unique identifier of the enterprise<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the enterprise.<br/>
        /// Example: Octo Business
        /// </summary>
        /// <example>Octo Business</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The slug url identifier for the enterprise.<br/>
        /// Example: octo-business
        /// </summary>
        /// <example>octo-business</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseWebhooks" /> class.
        /// </summary>
        /// <param name="description">
        /// A short description of the enterprise.
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/enterprises/octo-business
        /// </param>
        /// <param name="websiteUrl">
        /// The enterprise's website URL.
        /// </param>
        /// <param name="id">
        /// Unique identifier of the enterprise<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </param>
        /// <param name="name">
        /// The name of the enterprise.<br/>
        /// Example: Octo Business
        /// </param>
        /// <param name="slug">
        /// The slug url identifier for the enterprise.<br/>
        /// Example: octo-business
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="avatarUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseWebhooks(
            string htmlUrl,
            int id,
            string nodeId,
            string name,
            string slug,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string avatarUrl,
            string? description,
            string? websiteUrl)
        {
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Description = description;
            this.WebsiteUrl = websiteUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseWebhooks" /> class.
        /// </summary>
        public EnterpriseWebhooks()
        {
        }
    }
}