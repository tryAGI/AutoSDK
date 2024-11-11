//HintName: G.Models.WebhookSubIssuesSubIssueRemoved.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSubIssuesSubIssueRemoved
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookSubIssuesSubIssueRemovedActionJsonConverter))]
        public global::G.WebhookSubIssuesSubIssueRemovedAction Action { get; set; }

        /// <summary>
        /// The ID of the sub-issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SubIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Issue SubIssue { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue_repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Repository SubIssueRepo { get; set; }

        /// <summary>
        /// The ID of the parent issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ParentIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Issue ParentIssue { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::G.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::G.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        public global::G.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubIssuesSubIssueRemoved" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="subIssueId">
        /// The ID of the sub-issue.
        /// </param>
        /// <param name="subIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="subIssueRepo">
        /// A repository on GitHub.
        /// </param>
        /// <param name="parentIssueId">
        /// The ID of the parent issue.
        /// </param>
        /// <param name="parentIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookSubIssuesSubIssueRemoved(
            double subIssueId,
            global::G.Issue subIssue,
            global::G.Repository subIssueRepo,
            double parentIssueId,
            global::G.Issue parentIssue,
            global::G.WebhookSubIssuesSubIssueRemovedAction action,
            global::G.SimpleInstallation? installation,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.RepositoryWebhooks? repository,
            global::G.SimpleUser? sender)
        {
            this.SubIssueId = subIssueId;
            this.SubIssue = subIssue ?? throw new global::System.ArgumentNullException(nameof(subIssue));
            this.SubIssueRepo = subIssueRepo ?? throw new global::System.ArgumentNullException(nameof(subIssueRepo));
            this.ParentIssueId = parentIssueId;
            this.ParentIssue = parentIssue ?? throw new global::System.ArgumentNullException(nameof(parentIssue));
            this.Action = action;
            this.Installation = installation;
            this.Organization = organization;
            this.Repository = repository;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubIssuesSubIssueRemoved" /> class.
        /// </summary>
        public WebhookSubIssuesSubIssueRemoved()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.WebhookSubIssuesSubIssueRemoved? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookSubIssuesSubIssueRemoved),
                jsonSerializerContext) as global::G.WebhookSubIssuesSubIssueRemoved;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookSubIssuesSubIssueRemoved? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookSubIssuesSubIssueRemoved>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookSubIssuesSubIssueRemoved?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookSubIssuesSubIssueRemoved),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookSubIssuesSubIssueRemoved;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookSubIssuesSubIssueRemoved?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookSubIssuesSubIssueRemoved?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}