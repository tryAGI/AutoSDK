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
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string After { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? BaseRef { get; set; }

        /// <summary>
        /// The SHA of the most recent commit on `ref` before the push.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Before { get; set; }

        /// <summary>
        /// An array of commit objects describing the pushed commits. (Pushed commits are all commits that are included in the `compare` between the `before` commit and the `after` commit.) The array includes a maximum of 2048 commits. If necessary, you can use the [Commits API](https://docs.github.com/rest/commits) to fetch additional commits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookPushCommit> Commits { get; set; }

        /// <summary>
        /// URL that shows the changes in this `ref` update, from the `before` commit to the `after` commit. For a newly created `ref` that is directly based on the default branch, this is the comparison between the head of the default branch and the `after` commit. Otherwise, this shows all commits until the `after` commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Compare { get; set; }

        /// <summary>
        /// Whether this push created the `ref`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Created { get; set; }

        /// <summary>
        /// Whether this push deleted the `ref`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// Whether this push was a force push of the `ref`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Forced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushHeadCommit? HeadCommit { get; set; }

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
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushPusher Pusher { get; set; }

        /// <summary>
        /// The full git ref that was pushed. Example: `refs/heads/main` or `refs/tags/v3.14.1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// A git repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushRepository Repository { get; set; }

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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
    }
}