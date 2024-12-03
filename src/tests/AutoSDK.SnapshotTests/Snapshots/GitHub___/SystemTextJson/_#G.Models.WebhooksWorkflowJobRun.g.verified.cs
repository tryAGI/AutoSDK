//HintName: G.Models.WebhooksWorkflowJobRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksWorkflowJobRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksWorkflowJobRun" /> class.
        /// </summary>
        /// <param name="conclusion"></param>
        /// <param name="createdAt"></param>
        /// <param name="environment"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksWorkflowJobRun(
            object? conclusion,
            string createdAt,
            string environment,
            string htmlUrl,
            int id,
            object? name,
            string status,
            string updatedAt)
        {
            this.Conclusion = conclusion ?? throw new global::System.ArgumentNullException(nameof(conclusion));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksWorkflowJobRun" /> class.
        /// </summary>
        public WebhooksWorkflowJobRun()
        {
        }
    }
}