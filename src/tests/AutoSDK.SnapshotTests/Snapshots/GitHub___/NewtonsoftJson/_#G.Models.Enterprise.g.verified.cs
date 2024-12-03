//HintName: G.Models.Enterprise.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enterprise on GitHub.
    /// </summary>
    public sealed partial class Enterprise
    {
        /// <summary>
        /// A short description of the enterprise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: https://github.com/enterprises/octo-business
        /// </summary>
        /// <example>https://github.com/enterprises/octo-business</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The enterprise's website URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// Unique identifier of the enterprise<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the enterprise.<br/>
        /// Example: Octo Business
        /// </summary>
        /// <example>Octo Business</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The slug url identifier for the enterprise.<br/>
        /// Example: octo-business
        /// </summary>
        /// <example>octo-business</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Enterprise" /> class.
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
        public Enterprise(
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
        /// Initializes a new instance of the <see cref="Enterprise" /> class.
        /// </summary>
        public Enterprise()
        {
        }
    }
}