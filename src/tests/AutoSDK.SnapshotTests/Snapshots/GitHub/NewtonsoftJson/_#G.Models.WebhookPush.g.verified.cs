//HintName: G.Models.WebhookPush.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPush
    {
        /// <summary>
        /// The SHA of the most recent commit on `ref` after the push.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after", Required = global::Newtonsoft.Json.Required.Always)]
        public string After { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string? BaseRef { get; set; } = default!;

        /// <summary>
        /// The SHA of the most recent commit on `ref` before the push.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before", Required = global::Newtonsoft.Json.Required.Always)]
        public string Before { get; set; } = default!;

        /// <summary>
        /// An array of commit objects describing the pushed commits. (Pushed commits are all commits that are included in the `compare` between the `before` commit and the `after` commit.) The array includes a maximum of 2048 commits. If necessary, you can use the [Commits API](https://docs.github.com/rest/commits) to fetch additional commits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPushCommit> Commits { get; set; } = default!;

        /// <summary>
        /// URL that shows the changes in this `ref` update, from the `before` commit to the `after` commit. For a newly created `ref` that is directly based on the default branch, this is the comparison between the head of the default branch and the `after` commit. Otherwise, this shows all commits until the `after` commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compare", Required = global::Newtonsoft.Json.Required.Always)]
        public string Compare { get; set; } = default!;

        /// <summary>
        /// Whether this push created the `ref`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Created { get; set; } = default!;

        /// <summary>
        /// Whether this push deleted the `ref`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// Whether this push was a force push of the `ref`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forced", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Forced { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPushHeadCommit? HeadCommit { get; set; } = default!;

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation")]
        public global::G.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pusher", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPushPusher Pusher { get; set; } = default!;

        /// <summary>
        /// The full git ref that was pushed. Example: `refs/heads/main` or `refs/tags/v3.14.1`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPushRepository Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender")]
        public global::G.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPush" /> class.
        /// </summary>
        /// <param name="after">
        /// The SHA of the most recent commit on `ref` after the push.
        /// </param>
        /// <param name="baseRef"></param>
        /// <param name="before">
        /// The SHA of the most recent commit on `ref` before the push.
        /// </param>
        /// <param name="commits">
        /// An array of commit objects describing the pushed commits. (Pushed commits are all commits that are included in the `compare` between the `before` commit and the `after` commit.) The array includes a maximum of 2048 commits. If necessary, you can use the [Commits API](https://docs.github.com/rest/commits) to fetch additional commits.
        /// </param>
        /// <param name="compare">
        /// URL that shows the changes in this `ref` update, from the `before` commit to the `after` commit. For a newly created `ref` that is directly based on the default branch, this is the comparison between the head of the default branch and the `after` commit. Otherwise, this shows all commits until the `after` commit.
        /// </param>
        /// <param name="created">
        /// Whether this push created the `ref`.
        /// </param>
        /// <param name="deleted">
        /// Whether this push deleted the `ref`.
        /// </param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="forced">
        /// Whether this push was a force push of the `ref`.
        /// </param>
        /// <param name="headCommit"></param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="pusher">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="ref">
        /// The full git ref that was pushed. Example: `refs/heads/main` or `refs/tags/v3.14.1`.
        /// </param>
        /// <param name="repository">
        /// A git repository
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        public WebhookPush(
            string after,
            string? baseRef,
            string before,
            global::System.Collections.Generic.IList<global::G.WebhookPushCommit> commits,
            string compare,
            bool created,
            bool deleted,
            bool forced,
            global::G.WebhookPushHeadCommit? headCommit,
            global::G.WebhookPushPusher pusher,
            string @ref,
            global::G.WebhookPushRepository repository,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.SimpleInstallation? installation,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.SimpleUser? sender)
        {
            this.After = after ?? throw new global::System.ArgumentNullException(nameof(after));
            this.BaseRef = baseRef ?? throw new global::System.ArgumentNullException(nameof(baseRef));
            this.Before = before ?? throw new global::System.ArgumentNullException(nameof(before));
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Compare = compare ?? throw new global::System.ArgumentNullException(nameof(compare));
            this.Created = created;
            this.Deleted = deleted;
            this.Forced = forced;
            this.HeadCommit = headCommit ?? throw new global::System.ArgumentNullException(nameof(headCommit));
            this.Pusher = pusher ?? throw new global::System.ArgumentNullException(nameof(pusher));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Organization = organization;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPush" /> class.
        /// </summary>
        public WebhookPush()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookPush? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPush>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPush?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookPush?>(serializer.Deserialize<global::G.WebhookPush>(jsonReader));
        }

    }
}