//HintName: G.Models.Workflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Actions workflow
    /// </summary>
    public sealed partial class Workflow
    {
        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDg6V29ya2Zsb3cxMg==
        /// </summary>
        /// <example>MDg6V29ya2Zsb3cxMg==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: CI
        /// </summary>
        /// <example>CI</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: ruby.yaml
        /// </summary>
        /// <example>ruby.yaml</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkflowState State { get; set; } = default!;

        /// <summary>
        /// Example: 2019-12-06T14:20:20.000Z
        /// </summary>
        /// <example>2019-12-06T14:20:20.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2019-12-06T14:20:20.000Z
        /// </summary>
        /// <example>2019-12-06T14:20:20.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/actions/setup-ruby/workflows/5
        /// </summary>
        /// <example>https://api.github.com/repos/actions/setup-ruby/workflows/5</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/actions/setup-ruby/blob/master/.github/workflows/ruby.yaml
        /// </summary>
        /// <example>https://github.com/actions/setup-ruby/blob/master/.github/workflows/ruby.yaml</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/actions/setup-ruby/workflows/CI/badge.svg
        /// </summary>
        /// <example>https://github.com/actions/setup-ruby/workflows/CI/badge.svg</example>
        [global::Newtonsoft.Json.JsonProperty("badge_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BadgeUrl { get; set; } = default!;

        /// <summary>
        /// Example: 2019-12-06T14:20:20.000Z
        /// </summary>
        /// <example>2019-12-06T14:20:20.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 5
        /// </param>
        /// <param name="nodeId">
        /// Example: MDg6V29ya2Zsb3cxMg==
        /// </param>
        /// <param name="name">
        /// Example: CI
        /// </param>
        /// <param name="path">
        /// Example: ruby.yaml
        /// </param>
        /// <param name="state">
        /// Example: active
        /// </param>
        /// <param name="createdAt">
        /// Example: 2019-12-06T14:20:20.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2019-12-06T14:20:20.000Z
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/actions/setup-ruby/workflows/5
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/actions/setup-ruby/blob/master/.github/workflows/ruby.yaml
        /// </param>
        /// <param name="badgeUrl">
        /// Example: https://github.com/actions/setup-ruby/workflows/CI/badge.svg
        /// </param>
        /// <param name="deletedAt">
        /// Example: 2019-12-06T14:20:20.000Z
        /// </param>
        public Workflow(
            int id,
            string nodeId,
            string name,
            string path,
            global::G.WorkflowState state,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string url,
            string htmlUrl,
            string badgeUrl,
            global::System.DateTime? deletedAt)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.State = state;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.BadgeUrl = badgeUrl ?? throw new global::System.ArgumentNullException(nameof(badgeUrl));
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        public Workflow()
        {
        }
    }
}