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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDg6V29ya2Zsb3cxMg==
        /// </summary>
        /// <example>MDg6V29ya2Zsb3cxMg==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: CI
        /// </summary>
        /// <example>CI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: ruby.yaml
        /// </summary>
        /// <example>ruby.yaml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkflowStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkflowState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/actions/setup-ruby/workflows/5
        /// </summary>
        /// <example>https://api.github.com/repos/actions/setup-ruby/workflows/5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/actions/setup-ruby/blob/master/.github/workflows/ruby.yaml
        /// </summary>
        /// <example>https://github.com/actions/setup-ruby/blob/master/.github/workflows/ruby.yaml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/actions/setup-ruby/workflows/CI/badge.svg
        /// </summary>
        /// <example>https://github.com/actions/setup-ruby/workflows/CI/badge.svg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BadgeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/actions/setup-ruby/workflows/5
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/actions/setup-ruby/blob/master/.github/workflows/ruby.yaml
        /// </param>
        /// <param name="badgeUrl">
        /// Example: https://github.com/actions/setup-ruby/workflows/CI/badge.svg
        /// </param>
        /// <param name="deletedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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