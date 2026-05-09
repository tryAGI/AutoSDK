//HintName: G.JsonConverters.IssueEventForIssue.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class IssueEventForIssueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.IssueEventForIssue>
    {
        /// <inheritdoc />
        public override global::G.IssueEventForIssue Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("actor")) __score0++;
            if (__jsonProps.Contains("actor.avatar_url")) __score0++;
            if (__jsonProps.Contains("actor.email")) __score0++;
            if (__jsonProps.Contains("actor.events_url")) __score0++;
            if (__jsonProps.Contains("actor.followers_url")) __score0++;
            if (__jsonProps.Contains("actor.following_url")) __score0++;
            if (__jsonProps.Contains("actor.gists_url")) __score0++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score0++;
            if (__jsonProps.Contains("actor.html_url")) __score0++;
            if (__jsonProps.Contains("actor.id")) __score0++;
            if (__jsonProps.Contains("actor.login")) __score0++;
            if (__jsonProps.Contains("actor.name")) __score0++;
            if (__jsonProps.Contains("actor.node_id")) __score0++;
            if (__jsonProps.Contains("actor.organizations_url")) __score0++;
            if (__jsonProps.Contains("actor.received_events_url")) __score0++;
            if (__jsonProps.Contains("actor.repos_url")) __score0++;
            if (__jsonProps.Contains("actor.site_admin")) __score0++;
            if (__jsonProps.Contains("actor.starred_at")) __score0++;
            if (__jsonProps.Contains("actor.starred_url")) __score0++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("actor.type")) __score0++;
            if (__jsonProps.Contains("actor.url")) __score0++;
            if (__jsonProps.Contains("commit_id")) __score0++;
            if (__jsonProps.Contains("commit_url")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("event")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("label")) __score0++;
            if (__jsonProps.Contains("label.color")) __score0++;
            if (__jsonProps.Contains("label.name")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("actor")) __score1++;
            if (__jsonProps.Contains("actor.avatar_url")) __score1++;
            if (__jsonProps.Contains("actor.email")) __score1++;
            if (__jsonProps.Contains("actor.events_url")) __score1++;
            if (__jsonProps.Contains("actor.followers_url")) __score1++;
            if (__jsonProps.Contains("actor.following_url")) __score1++;
            if (__jsonProps.Contains("actor.gists_url")) __score1++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score1++;
            if (__jsonProps.Contains("actor.html_url")) __score1++;
            if (__jsonProps.Contains("actor.id")) __score1++;
            if (__jsonProps.Contains("actor.login")) __score1++;
            if (__jsonProps.Contains("actor.name")) __score1++;
            if (__jsonProps.Contains("actor.node_id")) __score1++;
            if (__jsonProps.Contains("actor.organizations_url")) __score1++;
            if (__jsonProps.Contains("actor.received_events_url")) __score1++;
            if (__jsonProps.Contains("actor.repos_url")) __score1++;
            if (__jsonProps.Contains("actor.site_admin")) __score1++;
            if (__jsonProps.Contains("actor.starred_at")) __score1++;
            if (__jsonProps.Contains("actor.starred_url")) __score1++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score1++;
            if (__jsonProps.Contains("actor.type")) __score1++;
            if (__jsonProps.Contains("actor.url")) __score1++;
            if (__jsonProps.Contains("commit_id")) __score1++;
            if (__jsonProps.Contains("commit_url")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("label")) __score1++;
            if (__jsonProps.Contains("label.color")) __score1++;
            if (__jsonProps.Contains("label.name")) __score1++;
            if (__jsonProps.Contains("node_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("actor")) __score2++;
            if (__jsonProps.Contains("actor.avatar_url")) __score2++;
            if (__jsonProps.Contains("actor.email")) __score2++;
            if (__jsonProps.Contains("actor.events_url")) __score2++;
            if (__jsonProps.Contains("actor.followers_url")) __score2++;
            if (__jsonProps.Contains("actor.following_url")) __score2++;
            if (__jsonProps.Contains("actor.gists_url")) __score2++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score2++;
            if (__jsonProps.Contains("actor.html_url")) __score2++;
            if (__jsonProps.Contains("actor.id")) __score2++;
            if (__jsonProps.Contains("actor.login")) __score2++;
            if (__jsonProps.Contains("actor.name")) __score2++;
            if (__jsonProps.Contains("actor.node_id")) __score2++;
            if (__jsonProps.Contains("actor.organizations_url")) __score2++;
            if (__jsonProps.Contains("actor.received_events_url")) __score2++;
            if (__jsonProps.Contains("actor.repos_url")) __score2++;
            if (__jsonProps.Contains("actor.site_admin")) __score2++;
            if (__jsonProps.Contains("actor.starred_at")) __score2++;
            if (__jsonProps.Contains("actor.starred_url")) __score2++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score2++;
            if (__jsonProps.Contains("actor.type")) __score2++;
            if (__jsonProps.Contains("actor.url")) __score2++;
            if (__jsonProps.Contains("assignee")) __score2++;
            if (__jsonProps.Contains("assignee.avatar_url")) __score2++;
            if (__jsonProps.Contains("assignee.email")) __score2++;
            if (__jsonProps.Contains("assignee.events_url")) __score2++;
            if (__jsonProps.Contains("assignee.followers_url")) __score2++;
            if (__jsonProps.Contains("assignee.following_url")) __score2++;
            if (__jsonProps.Contains("assignee.gists_url")) __score2++;
            if (__jsonProps.Contains("assignee.gravatar_id")) __score2++;
            if (__jsonProps.Contains("assignee.html_url")) __score2++;
            if (__jsonProps.Contains("assignee.id")) __score2++;
            if (__jsonProps.Contains("assignee.login")) __score2++;
            if (__jsonProps.Contains("assignee.name")) __score2++;
            if (__jsonProps.Contains("assignee.node_id")) __score2++;
            if (__jsonProps.Contains("assignee.organizations_url")) __score2++;
            if (__jsonProps.Contains("assignee.received_events_url")) __score2++;
            if (__jsonProps.Contains("assignee.repos_url")) __score2++;
            if (__jsonProps.Contains("assignee.site_admin")) __score2++;
            if (__jsonProps.Contains("assignee.starred_at")) __score2++;
            if (__jsonProps.Contains("assignee.starred_url")) __score2++;
            if (__jsonProps.Contains("assignee.subscriptions_url")) __score2++;
            if (__jsonProps.Contains("assignee.type")) __score2++;
            if (__jsonProps.Contains("assignee.url")) __score2++;
            if (__jsonProps.Contains("assigner")) __score2++;
            if (__jsonProps.Contains("assigner.avatar_url")) __score2++;
            if (__jsonProps.Contains("assigner.email")) __score2++;
            if (__jsonProps.Contains("assigner.events_url")) __score2++;
            if (__jsonProps.Contains("assigner.followers_url")) __score2++;
            if (__jsonProps.Contains("assigner.following_url")) __score2++;
            if (__jsonProps.Contains("assigner.gists_url")) __score2++;
            if (__jsonProps.Contains("assigner.gravatar_id")) __score2++;
            if (__jsonProps.Contains("assigner.html_url")) __score2++;
            if (__jsonProps.Contains("assigner.id")) __score2++;
            if (__jsonProps.Contains("assigner.login")) __score2++;
            if (__jsonProps.Contains("assigner.name")) __score2++;
            if (__jsonProps.Contains("assigner.node_id")) __score2++;
            if (__jsonProps.Contains("assigner.organizations_url")) __score2++;
            if (__jsonProps.Contains("assigner.received_events_url")) __score2++;
            if (__jsonProps.Contains("assigner.repos_url")) __score2++;
            if (__jsonProps.Contains("assigner.site_admin")) __score2++;
            if (__jsonProps.Contains("assigner.starred_at")) __score2++;
            if (__jsonProps.Contains("assigner.starred_url")) __score2++;
            if (__jsonProps.Contains("assigner.subscriptions_url")) __score2++;
            if (__jsonProps.Contains("assigner.type")) __score2++;
            if (__jsonProps.Contains("assigner.url")) __score2++;
            if (__jsonProps.Contains("commit_id")) __score2++;
            if (__jsonProps.Contains("commit_url")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("event")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("node_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("actor")) __score3++;
            if (__jsonProps.Contains("actor.avatar_url")) __score3++;
            if (__jsonProps.Contains("actor.email")) __score3++;
            if (__jsonProps.Contains("actor.events_url")) __score3++;
            if (__jsonProps.Contains("actor.followers_url")) __score3++;
            if (__jsonProps.Contains("actor.following_url")) __score3++;
            if (__jsonProps.Contains("actor.gists_url")) __score3++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score3++;
            if (__jsonProps.Contains("actor.html_url")) __score3++;
            if (__jsonProps.Contains("actor.id")) __score3++;
            if (__jsonProps.Contains("actor.login")) __score3++;
            if (__jsonProps.Contains("actor.name")) __score3++;
            if (__jsonProps.Contains("actor.node_id")) __score3++;
            if (__jsonProps.Contains("actor.organizations_url")) __score3++;
            if (__jsonProps.Contains("actor.received_events_url")) __score3++;
            if (__jsonProps.Contains("actor.repos_url")) __score3++;
            if (__jsonProps.Contains("actor.site_admin")) __score3++;
            if (__jsonProps.Contains("actor.starred_at")) __score3++;
            if (__jsonProps.Contains("actor.starred_url")) __score3++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score3++;
            if (__jsonProps.Contains("actor.type")) __score3++;
            if (__jsonProps.Contains("actor.url")) __score3++;
            if (__jsonProps.Contains("assignee")) __score3++;
            if (__jsonProps.Contains("assignee.avatar_url")) __score3++;
            if (__jsonProps.Contains("assignee.email")) __score3++;
            if (__jsonProps.Contains("assignee.events_url")) __score3++;
            if (__jsonProps.Contains("assignee.followers_url")) __score3++;
            if (__jsonProps.Contains("assignee.following_url")) __score3++;
            if (__jsonProps.Contains("assignee.gists_url")) __score3++;
            if (__jsonProps.Contains("assignee.gravatar_id")) __score3++;
            if (__jsonProps.Contains("assignee.html_url")) __score3++;
            if (__jsonProps.Contains("assignee.id")) __score3++;
            if (__jsonProps.Contains("assignee.login")) __score3++;
            if (__jsonProps.Contains("assignee.name")) __score3++;
            if (__jsonProps.Contains("assignee.node_id")) __score3++;
            if (__jsonProps.Contains("assignee.organizations_url")) __score3++;
            if (__jsonProps.Contains("assignee.received_events_url")) __score3++;
            if (__jsonProps.Contains("assignee.repos_url")) __score3++;
            if (__jsonProps.Contains("assignee.site_admin")) __score3++;
            if (__jsonProps.Contains("assignee.starred_at")) __score3++;
            if (__jsonProps.Contains("assignee.starred_url")) __score3++;
            if (__jsonProps.Contains("assignee.subscriptions_url")) __score3++;
            if (__jsonProps.Contains("assignee.type")) __score3++;
            if (__jsonProps.Contains("assignee.url")) __score3++;
            if (__jsonProps.Contains("assigner")) __score3++;
            if (__jsonProps.Contains("assigner.avatar_url")) __score3++;
            if (__jsonProps.Contains("assigner.email")) __score3++;
            if (__jsonProps.Contains("assigner.events_url")) __score3++;
            if (__jsonProps.Contains("assigner.followers_url")) __score3++;
            if (__jsonProps.Contains("assigner.following_url")) __score3++;
            if (__jsonProps.Contains("assigner.gists_url")) __score3++;
            if (__jsonProps.Contains("assigner.gravatar_id")) __score3++;
            if (__jsonProps.Contains("assigner.html_url")) __score3++;
            if (__jsonProps.Contains("assigner.id")) __score3++;
            if (__jsonProps.Contains("assigner.login")) __score3++;
            if (__jsonProps.Contains("assigner.name")) __score3++;
            if (__jsonProps.Contains("assigner.node_id")) __score3++;
            if (__jsonProps.Contains("assigner.organizations_url")) __score3++;
            if (__jsonProps.Contains("assigner.received_events_url")) __score3++;
            if (__jsonProps.Contains("assigner.repos_url")) __score3++;
            if (__jsonProps.Contains("assigner.site_admin")) __score3++;
            if (__jsonProps.Contains("assigner.starred_at")) __score3++;
            if (__jsonProps.Contains("assigner.starred_url")) __score3++;
            if (__jsonProps.Contains("assigner.subscriptions_url")) __score3++;
            if (__jsonProps.Contains("assigner.type")) __score3++;
            if (__jsonProps.Contains("assigner.url")) __score3++;
            if (__jsonProps.Contains("commit_id")) __score3++;
            if (__jsonProps.Contains("commit_url")) __score3++;
            if (__jsonProps.Contains("created_at")) __score3++;
            if (__jsonProps.Contains("event")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("node_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("actor")) __score4++;
            if (__jsonProps.Contains("actor.avatar_url")) __score4++;
            if (__jsonProps.Contains("actor.email")) __score4++;
            if (__jsonProps.Contains("actor.events_url")) __score4++;
            if (__jsonProps.Contains("actor.followers_url")) __score4++;
            if (__jsonProps.Contains("actor.following_url")) __score4++;
            if (__jsonProps.Contains("actor.gists_url")) __score4++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score4++;
            if (__jsonProps.Contains("actor.html_url")) __score4++;
            if (__jsonProps.Contains("actor.id")) __score4++;
            if (__jsonProps.Contains("actor.login")) __score4++;
            if (__jsonProps.Contains("actor.name")) __score4++;
            if (__jsonProps.Contains("actor.node_id")) __score4++;
            if (__jsonProps.Contains("actor.organizations_url")) __score4++;
            if (__jsonProps.Contains("actor.received_events_url")) __score4++;
            if (__jsonProps.Contains("actor.repos_url")) __score4++;
            if (__jsonProps.Contains("actor.site_admin")) __score4++;
            if (__jsonProps.Contains("actor.starred_at")) __score4++;
            if (__jsonProps.Contains("actor.starred_url")) __score4++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score4++;
            if (__jsonProps.Contains("actor.type")) __score4++;
            if (__jsonProps.Contains("actor.url")) __score4++;
            if (__jsonProps.Contains("commit_id")) __score4++;
            if (__jsonProps.Contains("commit_url")) __score4++;
            if (__jsonProps.Contains("created_at")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("milestone")) __score4++;
            if (__jsonProps.Contains("milestone.title")) __score4++;
            if (__jsonProps.Contains("node_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score4++;
            if (__jsonProps.Contains("url")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("actor")) __score5++;
            if (__jsonProps.Contains("actor.avatar_url")) __score5++;
            if (__jsonProps.Contains("actor.email")) __score5++;
            if (__jsonProps.Contains("actor.events_url")) __score5++;
            if (__jsonProps.Contains("actor.followers_url")) __score5++;
            if (__jsonProps.Contains("actor.following_url")) __score5++;
            if (__jsonProps.Contains("actor.gists_url")) __score5++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score5++;
            if (__jsonProps.Contains("actor.html_url")) __score5++;
            if (__jsonProps.Contains("actor.id")) __score5++;
            if (__jsonProps.Contains("actor.login")) __score5++;
            if (__jsonProps.Contains("actor.name")) __score5++;
            if (__jsonProps.Contains("actor.node_id")) __score5++;
            if (__jsonProps.Contains("actor.organizations_url")) __score5++;
            if (__jsonProps.Contains("actor.received_events_url")) __score5++;
            if (__jsonProps.Contains("actor.repos_url")) __score5++;
            if (__jsonProps.Contains("actor.site_admin")) __score5++;
            if (__jsonProps.Contains("actor.starred_at")) __score5++;
            if (__jsonProps.Contains("actor.starred_url")) __score5++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score5++;
            if (__jsonProps.Contains("actor.type")) __score5++;
            if (__jsonProps.Contains("actor.url")) __score5++;
            if (__jsonProps.Contains("commit_id")) __score5++;
            if (__jsonProps.Contains("commit_url")) __score5++;
            if (__jsonProps.Contains("created_at")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("milestone")) __score5++;
            if (__jsonProps.Contains("milestone.title")) __score5++;
            if (__jsonProps.Contains("node_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score5++;
            if (__jsonProps.Contains("url")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("actor")) __score6++;
            if (__jsonProps.Contains("actor.avatar_url")) __score6++;
            if (__jsonProps.Contains("actor.email")) __score6++;
            if (__jsonProps.Contains("actor.events_url")) __score6++;
            if (__jsonProps.Contains("actor.followers_url")) __score6++;
            if (__jsonProps.Contains("actor.following_url")) __score6++;
            if (__jsonProps.Contains("actor.gists_url")) __score6++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score6++;
            if (__jsonProps.Contains("actor.html_url")) __score6++;
            if (__jsonProps.Contains("actor.id")) __score6++;
            if (__jsonProps.Contains("actor.login")) __score6++;
            if (__jsonProps.Contains("actor.name")) __score6++;
            if (__jsonProps.Contains("actor.node_id")) __score6++;
            if (__jsonProps.Contains("actor.organizations_url")) __score6++;
            if (__jsonProps.Contains("actor.received_events_url")) __score6++;
            if (__jsonProps.Contains("actor.repos_url")) __score6++;
            if (__jsonProps.Contains("actor.site_admin")) __score6++;
            if (__jsonProps.Contains("actor.starred_at")) __score6++;
            if (__jsonProps.Contains("actor.starred_url")) __score6++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score6++;
            if (__jsonProps.Contains("actor.type")) __score6++;
            if (__jsonProps.Contains("actor.url")) __score6++;
            if (__jsonProps.Contains("commit_id")) __score6++;
            if (__jsonProps.Contains("commit_url")) __score6++;
            if (__jsonProps.Contains("created_at")) __score6++;
            if (__jsonProps.Contains("event")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("node_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score6++;
            if (__jsonProps.Contains("rename")) __score6++;
            if (__jsonProps.Contains("rename.from")) __score6++;
            if (__jsonProps.Contains("rename.to")) __score6++;
            if (__jsonProps.Contains("url")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("actor")) __score7++;
            if (__jsonProps.Contains("actor.avatar_url")) __score7++;
            if (__jsonProps.Contains("actor.email")) __score7++;
            if (__jsonProps.Contains("actor.events_url")) __score7++;
            if (__jsonProps.Contains("actor.followers_url")) __score7++;
            if (__jsonProps.Contains("actor.following_url")) __score7++;
            if (__jsonProps.Contains("actor.gists_url")) __score7++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score7++;
            if (__jsonProps.Contains("actor.html_url")) __score7++;
            if (__jsonProps.Contains("actor.id")) __score7++;
            if (__jsonProps.Contains("actor.login")) __score7++;
            if (__jsonProps.Contains("actor.name")) __score7++;
            if (__jsonProps.Contains("actor.node_id")) __score7++;
            if (__jsonProps.Contains("actor.organizations_url")) __score7++;
            if (__jsonProps.Contains("actor.received_events_url")) __score7++;
            if (__jsonProps.Contains("actor.repos_url")) __score7++;
            if (__jsonProps.Contains("actor.site_admin")) __score7++;
            if (__jsonProps.Contains("actor.starred_at")) __score7++;
            if (__jsonProps.Contains("actor.starred_url")) __score7++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score7++;
            if (__jsonProps.Contains("actor.type")) __score7++;
            if (__jsonProps.Contains("actor.url")) __score7++;
            if (__jsonProps.Contains("commit_id")) __score7++;
            if (__jsonProps.Contains("commit_url")) __score7++;
            if (__jsonProps.Contains("created_at")) __score7++;
            if (__jsonProps.Contains("event")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("node_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score7++;
            if (__jsonProps.Contains("requested_reviewer")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.avatar_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.email")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.events_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.followers_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.following_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.gists_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.gravatar_id")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.html_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.id")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.login")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.name")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.node_id")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.organizations_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.received_events_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.repos_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.site_admin")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.starred_at")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.starred_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.subscriptions_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.type")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.url")) __score7++;
            if (__jsonProps.Contains("requested_team")) __score7++;
            if (__jsonProps.Contains("requested_team.description")) __score7++;
            if (__jsonProps.Contains("requested_team.html_url")) __score7++;
            if (__jsonProps.Contains("requested_team.id")) __score7++;
            if (__jsonProps.Contains("requested_team.members_url")) __score7++;
            if (__jsonProps.Contains("requested_team.name")) __score7++;
            if (__jsonProps.Contains("requested_team.node_id")) __score7++;
            if (__jsonProps.Contains("requested_team.notification_setting")) __score7++;
            if (__jsonProps.Contains("requested_team.parent")) __score7++;
            if (__jsonProps.Contains("requested_team.permission")) __score7++;
            if (__jsonProps.Contains("requested_team.permissions")) __score7++;
            if (__jsonProps.Contains("requested_team.privacy")) __score7++;
            if (__jsonProps.Contains("requested_team.repositories_url")) __score7++;
            if (__jsonProps.Contains("requested_team.slug")) __score7++;
            if (__jsonProps.Contains("requested_team.url")) __score7++;
            if (__jsonProps.Contains("review_requester")) __score7++;
            if (__jsonProps.Contains("review_requester.avatar_url")) __score7++;
            if (__jsonProps.Contains("review_requester.email")) __score7++;
            if (__jsonProps.Contains("review_requester.events_url")) __score7++;
            if (__jsonProps.Contains("review_requester.followers_url")) __score7++;
            if (__jsonProps.Contains("review_requester.following_url")) __score7++;
            if (__jsonProps.Contains("review_requester.gists_url")) __score7++;
            if (__jsonProps.Contains("review_requester.gravatar_id")) __score7++;
            if (__jsonProps.Contains("review_requester.html_url")) __score7++;
            if (__jsonProps.Contains("review_requester.id")) __score7++;
            if (__jsonProps.Contains("review_requester.login")) __score7++;
            if (__jsonProps.Contains("review_requester.name")) __score7++;
            if (__jsonProps.Contains("review_requester.node_id")) __score7++;
            if (__jsonProps.Contains("review_requester.organizations_url")) __score7++;
            if (__jsonProps.Contains("review_requester.received_events_url")) __score7++;
            if (__jsonProps.Contains("review_requester.repos_url")) __score7++;
            if (__jsonProps.Contains("review_requester.site_admin")) __score7++;
            if (__jsonProps.Contains("review_requester.starred_at")) __score7++;
            if (__jsonProps.Contains("review_requester.starred_url")) __score7++;
            if (__jsonProps.Contains("review_requester.subscriptions_url")) __score7++;
            if (__jsonProps.Contains("review_requester.type")) __score7++;
            if (__jsonProps.Contains("review_requester.url")) __score7++;
            if (__jsonProps.Contains("url")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("actor")) __score8++;
            if (__jsonProps.Contains("actor.avatar_url")) __score8++;
            if (__jsonProps.Contains("actor.email")) __score8++;
            if (__jsonProps.Contains("actor.events_url")) __score8++;
            if (__jsonProps.Contains("actor.followers_url")) __score8++;
            if (__jsonProps.Contains("actor.following_url")) __score8++;
            if (__jsonProps.Contains("actor.gists_url")) __score8++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score8++;
            if (__jsonProps.Contains("actor.html_url")) __score8++;
            if (__jsonProps.Contains("actor.id")) __score8++;
            if (__jsonProps.Contains("actor.login")) __score8++;
            if (__jsonProps.Contains("actor.name")) __score8++;
            if (__jsonProps.Contains("actor.node_id")) __score8++;
            if (__jsonProps.Contains("actor.organizations_url")) __score8++;
            if (__jsonProps.Contains("actor.received_events_url")) __score8++;
            if (__jsonProps.Contains("actor.repos_url")) __score8++;
            if (__jsonProps.Contains("actor.site_admin")) __score8++;
            if (__jsonProps.Contains("actor.starred_at")) __score8++;
            if (__jsonProps.Contains("actor.starred_url")) __score8++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score8++;
            if (__jsonProps.Contains("actor.type")) __score8++;
            if (__jsonProps.Contains("actor.url")) __score8++;
            if (__jsonProps.Contains("commit_id")) __score8++;
            if (__jsonProps.Contains("commit_url")) __score8++;
            if (__jsonProps.Contains("created_at")) __score8++;
            if (__jsonProps.Contains("event")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("node_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score8++;
            if (__jsonProps.Contains("requested_reviewer")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.avatar_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.email")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.events_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.followers_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.following_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.gists_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.gravatar_id")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.html_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.id")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.login")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.name")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.node_id")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.organizations_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.received_events_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.repos_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.site_admin")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.starred_at")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.starred_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.subscriptions_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.type")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.url")) __score8++;
            if (__jsonProps.Contains("requested_team")) __score8++;
            if (__jsonProps.Contains("requested_team.description")) __score8++;
            if (__jsonProps.Contains("requested_team.html_url")) __score8++;
            if (__jsonProps.Contains("requested_team.id")) __score8++;
            if (__jsonProps.Contains("requested_team.members_url")) __score8++;
            if (__jsonProps.Contains("requested_team.name")) __score8++;
            if (__jsonProps.Contains("requested_team.node_id")) __score8++;
            if (__jsonProps.Contains("requested_team.notification_setting")) __score8++;
            if (__jsonProps.Contains("requested_team.parent")) __score8++;
            if (__jsonProps.Contains("requested_team.permission")) __score8++;
            if (__jsonProps.Contains("requested_team.permissions")) __score8++;
            if (__jsonProps.Contains("requested_team.privacy")) __score8++;
            if (__jsonProps.Contains("requested_team.repositories_url")) __score8++;
            if (__jsonProps.Contains("requested_team.slug")) __score8++;
            if (__jsonProps.Contains("requested_team.url")) __score8++;
            if (__jsonProps.Contains("review_requester")) __score8++;
            if (__jsonProps.Contains("review_requester.avatar_url")) __score8++;
            if (__jsonProps.Contains("review_requester.email")) __score8++;
            if (__jsonProps.Contains("review_requester.events_url")) __score8++;
            if (__jsonProps.Contains("review_requester.followers_url")) __score8++;
            if (__jsonProps.Contains("review_requester.following_url")) __score8++;
            if (__jsonProps.Contains("review_requester.gists_url")) __score8++;
            if (__jsonProps.Contains("review_requester.gravatar_id")) __score8++;
            if (__jsonProps.Contains("review_requester.html_url")) __score8++;
            if (__jsonProps.Contains("review_requester.id")) __score8++;
            if (__jsonProps.Contains("review_requester.login")) __score8++;
            if (__jsonProps.Contains("review_requester.name")) __score8++;
            if (__jsonProps.Contains("review_requester.node_id")) __score8++;
            if (__jsonProps.Contains("review_requester.organizations_url")) __score8++;
            if (__jsonProps.Contains("review_requester.received_events_url")) __score8++;
            if (__jsonProps.Contains("review_requester.repos_url")) __score8++;
            if (__jsonProps.Contains("review_requester.site_admin")) __score8++;
            if (__jsonProps.Contains("review_requester.starred_at")) __score8++;
            if (__jsonProps.Contains("review_requester.starred_url")) __score8++;
            if (__jsonProps.Contains("review_requester.subscriptions_url")) __score8++;
            if (__jsonProps.Contains("review_requester.type")) __score8++;
            if (__jsonProps.Contains("review_requester.url")) __score8++;
            if (__jsonProps.Contains("url")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("actor")) __score9++;
            if (__jsonProps.Contains("actor.avatar_url")) __score9++;
            if (__jsonProps.Contains("actor.email")) __score9++;
            if (__jsonProps.Contains("actor.events_url")) __score9++;
            if (__jsonProps.Contains("actor.followers_url")) __score9++;
            if (__jsonProps.Contains("actor.following_url")) __score9++;
            if (__jsonProps.Contains("actor.gists_url")) __score9++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score9++;
            if (__jsonProps.Contains("actor.html_url")) __score9++;
            if (__jsonProps.Contains("actor.id")) __score9++;
            if (__jsonProps.Contains("actor.login")) __score9++;
            if (__jsonProps.Contains("actor.name")) __score9++;
            if (__jsonProps.Contains("actor.node_id")) __score9++;
            if (__jsonProps.Contains("actor.organizations_url")) __score9++;
            if (__jsonProps.Contains("actor.received_events_url")) __score9++;
            if (__jsonProps.Contains("actor.repos_url")) __score9++;
            if (__jsonProps.Contains("actor.site_admin")) __score9++;
            if (__jsonProps.Contains("actor.starred_at")) __score9++;
            if (__jsonProps.Contains("actor.starred_url")) __score9++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score9++;
            if (__jsonProps.Contains("actor.type")) __score9++;
            if (__jsonProps.Contains("actor.url")) __score9++;
            if (__jsonProps.Contains("commit_id")) __score9++;
            if (__jsonProps.Contains("commit_url")) __score9++;
            if (__jsonProps.Contains("created_at")) __score9++;
            if (__jsonProps.Contains("dismissed_review")) __score9++;
            if (__jsonProps.Contains("dismissed_review.dismissal_commit_id")) __score9++;
            if (__jsonProps.Contains("dismissed_review.dismissal_message")) __score9++;
            if (__jsonProps.Contains("dismissed_review.review_id")) __score9++;
            if (__jsonProps.Contains("dismissed_review.state")) __score9++;
            if (__jsonProps.Contains("event")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("node_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score9++;
            if (__jsonProps.Contains("url")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("actor")) __score10++;
            if (__jsonProps.Contains("actor.avatar_url")) __score10++;
            if (__jsonProps.Contains("actor.email")) __score10++;
            if (__jsonProps.Contains("actor.events_url")) __score10++;
            if (__jsonProps.Contains("actor.followers_url")) __score10++;
            if (__jsonProps.Contains("actor.following_url")) __score10++;
            if (__jsonProps.Contains("actor.gists_url")) __score10++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score10++;
            if (__jsonProps.Contains("actor.html_url")) __score10++;
            if (__jsonProps.Contains("actor.id")) __score10++;
            if (__jsonProps.Contains("actor.login")) __score10++;
            if (__jsonProps.Contains("actor.name")) __score10++;
            if (__jsonProps.Contains("actor.node_id")) __score10++;
            if (__jsonProps.Contains("actor.organizations_url")) __score10++;
            if (__jsonProps.Contains("actor.received_events_url")) __score10++;
            if (__jsonProps.Contains("actor.repos_url")) __score10++;
            if (__jsonProps.Contains("actor.site_admin")) __score10++;
            if (__jsonProps.Contains("actor.starred_at")) __score10++;
            if (__jsonProps.Contains("actor.starred_url")) __score10++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score10++;
            if (__jsonProps.Contains("actor.type")) __score10++;
            if (__jsonProps.Contains("actor.url")) __score10++;
            if (__jsonProps.Contains("commit_id")) __score10++;
            if (__jsonProps.Contains("commit_url")) __score10++;
            if (__jsonProps.Contains("created_at")) __score10++;
            if (__jsonProps.Contains("event")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("lock_reason")) __score10++;
            if (__jsonProps.Contains("node_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score10++;
            if (__jsonProps.Contains("url")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("actor")) __score11++;
            if (__jsonProps.Contains("actor.avatar_url")) __score11++;
            if (__jsonProps.Contains("actor.email")) __score11++;
            if (__jsonProps.Contains("actor.events_url")) __score11++;
            if (__jsonProps.Contains("actor.followers_url")) __score11++;
            if (__jsonProps.Contains("actor.following_url")) __score11++;
            if (__jsonProps.Contains("actor.gists_url")) __score11++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score11++;
            if (__jsonProps.Contains("actor.html_url")) __score11++;
            if (__jsonProps.Contains("actor.id")) __score11++;
            if (__jsonProps.Contains("actor.login")) __score11++;
            if (__jsonProps.Contains("actor.name")) __score11++;
            if (__jsonProps.Contains("actor.node_id")) __score11++;
            if (__jsonProps.Contains("actor.organizations_url")) __score11++;
            if (__jsonProps.Contains("actor.received_events_url")) __score11++;
            if (__jsonProps.Contains("actor.repos_url")) __score11++;
            if (__jsonProps.Contains("actor.site_admin")) __score11++;
            if (__jsonProps.Contains("actor.starred_at")) __score11++;
            if (__jsonProps.Contains("actor.starred_url")) __score11++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score11++;
            if (__jsonProps.Contains("actor.type")) __score11++;
            if (__jsonProps.Contains("actor.url")) __score11++;
            if (__jsonProps.Contains("commit_id")) __score11++;
            if (__jsonProps.Contains("commit_url")) __score11++;
            if (__jsonProps.Contains("created_at")) __score11++;
            if (__jsonProps.Contains("event")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("node_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score11++;
            if (__jsonProps.Contains("project_card")) __score11++;
            if (__jsonProps.Contains("project_card.column_name")) __score11++;
            if (__jsonProps.Contains("project_card.id")) __score11++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score11++;
            if (__jsonProps.Contains("project_card.project_id")) __score11++;
            if (__jsonProps.Contains("project_card.project_url")) __score11++;
            if (__jsonProps.Contains("project_card.url")) __score11++;
            if (__jsonProps.Contains("url")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("actor")) __score12++;
            if (__jsonProps.Contains("actor.avatar_url")) __score12++;
            if (__jsonProps.Contains("actor.email")) __score12++;
            if (__jsonProps.Contains("actor.events_url")) __score12++;
            if (__jsonProps.Contains("actor.followers_url")) __score12++;
            if (__jsonProps.Contains("actor.following_url")) __score12++;
            if (__jsonProps.Contains("actor.gists_url")) __score12++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score12++;
            if (__jsonProps.Contains("actor.html_url")) __score12++;
            if (__jsonProps.Contains("actor.id")) __score12++;
            if (__jsonProps.Contains("actor.login")) __score12++;
            if (__jsonProps.Contains("actor.name")) __score12++;
            if (__jsonProps.Contains("actor.node_id")) __score12++;
            if (__jsonProps.Contains("actor.organizations_url")) __score12++;
            if (__jsonProps.Contains("actor.received_events_url")) __score12++;
            if (__jsonProps.Contains("actor.repos_url")) __score12++;
            if (__jsonProps.Contains("actor.site_admin")) __score12++;
            if (__jsonProps.Contains("actor.starred_at")) __score12++;
            if (__jsonProps.Contains("actor.starred_url")) __score12++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score12++;
            if (__jsonProps.Contains("actor.type")) __score12++;
            if (__jsonProps.Contains("actor.url")) __score12++;
            if (__jsonProps.Contains("commit_id")) __score12++;
            if (__jsonProps.Contains("commit_url")) __score12++;
            if (__jsonProps.Contains("created_at")) __score12++;
            if (__jsonProps.Contains("event")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("node_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score12++;
            if (__jsonProps.Contains("project_card")) __score12++;
            if (__jsonProps.Contains("project_card.column_name")) __score12++;
            if (__jsonProps.Contains("project_card.id")) __score12++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score12++;
            if (__jsonProps.Contains("project_card.project_id")) __score12++;
            if (__jsonProps.Contains("project_card.project_url")) __score12++;
            if (__jsonProps.Contains("project_card.url")) __score12++;
            if (__jsonProps.Contains("url")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("actor")) __score13++;
            if (__jsonProps.Contains("actor.avatar_url")) __score13++;
            if (__jsonProps.Contains("actor.email")) __score13++;
            if (__jsonProps.Contains("actor.events_url")) __score13++;
            if (__jsonProps.Contains("actor.followers_url")) __score13++;
            if (__jsonProps.Contains("actor.following_url")) __score13++;
            if (__jsonProps.Contains("actor.gists_url")) __score13++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score13++;
            if (__jsonProps.Contains("actor.html_url")) __score13++;
            if (__jsonProps.Contains("actor.id")) __score13++;
            if (__jsonProps.Contains("actor.login")) __score13++;
            if (__jsonProps.Contains("actor.name")) __score13++;
            if (__jsonProps.Contains("actor.node_id")) __score13++;
            if (__jsonProps.Contains("actor.organizations_url")) __score13++;
            if (__jsonProps.Contains("actor.received_events_url")) __score13++;
            if (__jsonProps.Contains("actor.repos_url")) __score13++;
            if (__jsonProps.Contains("actor.site_admin")) __score13++;
            if (__jsonProps.Contains("actor.starred_at")) __score13++;
            if (__jsonProps.Contains("actor.starred_url")) __score13++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score13++;
            if (__jsonProps.Contains("actor.type")) __score13++;
            if (__jsonProps.Contains("actor.url")) __score13++;
            if (__jsonProps.Contains("commit_id")) __score13++;
            if (__jsonProps.Contains("commit_url")) __score13++;
            if (__jsonProps.Contains("created_at")) __score13++;
            if (__jsonProps.Contains("event")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("node_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score13++;
            if (__jsonProps.Contains("project_card")) __score13++;
            if (__jsonProps.Contains("project_card.column_name")) __score13++;
            if (__jsonProps.Contains("project_card.id")) __score13++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score13++;
            if (__jsonProps.Contains("project_card.project_id")) __score13++;
            if (__jsonProps.Contains("project_card.project_url")) __score13++;
            if (__jsonProps.Contains("project_card.url")) __score13++;
            if (__jsonProps.Contains("url")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("actor")) __score14++;
            if (__jsonProps.Contains("actor.avatar_url")) __score14++;
            if (__jsonProps.Contains("actor.email")) __score14++;
            if (__jsonProps.Contains("actor.events_url")) __score14++;
            if (__jsonProps.Contains("actor.followers_url")) __score14++;
            if (__jsonProps.Contains("actor.following_url")) __score14++;
            if (__jsonProps.Contains("actor.gists_url")) __score14++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score14++;
            if (__jsonProps.Contains("actor.html_url")) __score14++;
            if (__jsonProps.Contains("actor.id")) __score14++;
            if (__jsonProps.Contains("actor.login")) __score14++;
            if (__jsonProps.Contains("actor.name")) __score14++;
            if (__jsonProps.Contains("actor.node_id")) __score14++;
            if (__jsonProps.Contains("actor.organizations_url")) __score14++;
            if (__jsonProps.Contains("actor.received_events_url")) __score14++;
            if (__jsonProps.Contains("actor.repos_url")) __score14++;
            if (__jsonProps.Contains("actor.site_admin")) __score14++;
            if (__jsonProps.Contains("actor.starred_at")) __score14++;
            if (__jsonProps.Contains("actor.starred_url")) __score14++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score14++;
            if (__jsonProps.Contains("actor.type")) __score14++;
            if (__jsonProps.Contains("actor.url")) __score14++;
            if (__jsonProps.Contains("commit_id")) __score14++;
            if (__jsonProps.Contains("commit_url")) __score14++;
            if (__jsonProps.Contains("created_at")) __score14++;
            if (__jsonProps.Contains("event")) __score14++;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("node_id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.client_secret")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.pem")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.webhook_secret")) __score14++;
            if (__jsonProps.Contains("project_card")) __score14++;
            if (__jsonProps.Contains("project_card.column_name")) __score14++;
            if (__jsonProps.Contains("project_card.id")) __score14++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score14++;
            if (__jsonProps.Contains("project_card.project_id")) __score14++;
            if (__jsonProps.Contains("project_card.project_url")) __score14++;
            if (__jsonProps.Contains("project_card.url")) __score14++;
            if (__jsonProps.Contains("url")) __score14++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }

            global::G.LabeledIssueEvent? labeledIssueEvent = default;
            global::G.UnlabeledIssueEvent? unlabeledIssueEvent = default;
            global::G.AssignedIssueEvent? assignedIssueEvent = default;
            global::G.UnassignedIssueEvent? unassignedIssueEvent = default;
            global::G.MilestonedIssueEvent? milestonedIssueEvent = default;
            global::G.DemilestonedIssueEvent? demilestonedIssueEvent = default;
            global::G.RenamedIssueEvent? renamedIssueEvent = default;
            global::G.ReviewRequestedIssueEvent? reviewRequestedIssueEvent = default;
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent = default;
            global::G.ReviewDismissedIssueEvent? reviewDismissedIssueEvent = default;
            global::G.LockedIssueEvent? lockedIssueEvent = default;
            global::G.AddedToProjectIssueEvent? addedToProjectIssueEvent = default;
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent = default;
            global::G.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent = default;
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                        labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                        unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssignedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssignedIssueEvent).Name}");
                        assignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnassignedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnassignedIssueEvent).Name}");
                        unassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                        milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                        demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                        renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                        reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                        reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                        reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                        lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                        addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                        movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                        removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                        convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                    labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                    unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssignedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssignedIssueEvent).Name}");
                    assignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnassignedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnassignedIssueEvent).Name}");
                    unassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                    milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                    demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                    renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                    reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                    reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                    reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                    lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                    addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                    movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                    removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                    convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.IssueEventForIssue(
                labeledIssueEvent,

                unlabeledIssueEvent,

                assignedIssueEvent,

                unassignedIssueEvent,

                milestonedIssueEvent,

                demilestonedIssueEvent,

                renamedIssueEvent,

                reviewRequestedIssueEvent,

                reviewRequestRemovedIssueEvent,

                reviewDismissedIssueEvent,

                lockedIssueEvent,

                addedToProjectIssueEvent,

                movedColumnInProjectIssueEvent,

                removedFromProjectIssueEvent,

                convertedNoteToIssueIssueEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IssueEventForIssue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLabeledIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledIssueEvent!, typeInfo);
            }
            else if (value.IsUnlabeledIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnlabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnlabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledIssueEvent!, typeInfo);
            }
            else if (value.IsAssignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssignedIssueEvent!, typeInfo);
            }
            else if (value.IsUnassignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnassignedIssueEvent!, typeInfo);
            }
            else if (value.IsMilestonedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedIssueEvent!, typeInfo);
            }
            else if (value.IsDemilestonedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DemilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DemilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedIssueEvent!, typeInfo);
            }
            else if (value.IsRenamedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenamedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenamedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedIssueEvent!, typeInfo);
            }
            else if (value.IsReviewRequestedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedIssueEvent!, typeInfo);
            }
            else if (value.IsReviewRequestRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewRequestRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewRequestRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedIssueEvent!, typeInfo);
            }
            else if (value.IsReviewDismissedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReviewDismissedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReviewDismissedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedIssueEvent!, typeInfo);
            }
            else if (value.IsLockedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LockedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LockedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedIssueEvent!, typeInfo);
            }
            else if (value.IsAddedToProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AddedToProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AddedToProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectIssueEvent!, typeInfo);
            }
            else if (value.IsMovedColumnInProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MovedColumnInProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MovedColumnInProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectIssueEvent!, typeInfo);
            }
            else if (value.IsRemovedFromProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemovedFromProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RemovedFromProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectIssueEvent!, typeInfo);
            }
            else if (value.IsConvertedNoteToIssueIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvertedNoteToIssueIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConvertedNoteToIssueIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToIssueIssueEvent!, typeInfo);
            }
        }
    }
}