//HintName: G.JsonConverters.WebhookPullRequestReviewRequested.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WebhookPullRequestReviewRequestedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewRequested>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequested Read(
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
            if (__jsonProps.Contains("action")) __score0++;
            if (__jsonProps.Contains("enterprise")) __score0++;
            if (__jsonProps.Contains("enterprise.avatar_url")) __score0++;
            if (__jsonProps.Contains("enterprise.created_at")) __score0++;
            if (__jsonProps.Contains("enterprise.description")) __score0++;
            if (__jsonProps.Contains("enterprise.html_url")) __score0++;
            if (__jsonProps.Contains("enterprise.id")) __score0++;
            if (__jsonProps.Contains("enterprise.name")) __score0++;
            if (__jsonProps.Contains("enterprise.node_id")) __score0++;
            if (__jsonProps.Contains("enterprise.slug")) __score0++;
            if (__jsonProps.Contains("enterprise.updated_at")) __score0++;
            if (__jsonProps.Contains("enterprise.website_url")) __score0++;
            if (__jsonProps.Contains("installation")) __score0++;
            if (__jsonProps.Contains("installation.id")) __score0++;
            if (__jsonProps.Contains("installation.node_id")) __score0++;
            if (__jsonProps.Contains("number")) __score0++;
            if (__jsonProps.Contains("organization")) __score0++;
            if (__jsonProps.Contains("organization.avatar_url")) __score0++;
            if (__jsonProps.Contains("organization.description")) __score0++;
            if (__jsonProps.Contains("organization.events_url")) __score0++;
            if (__jsonProps.Contains("organization.hooks_url")) __score0++;
            if (__jsonProps.Contains("organization.id")) __score0++;
            if (__jsonProps.Contains("organization.issues_url")) __score0++;
            if (__jsonProps.Contains("organization.login")) __score0++;
            if (__jsonProps.Contains("organization.members_url")) __score0++;
            if (__jsonProps.Contains("organization.node_id")) __score0++;
            if (__jsonProps.Contains("organization.public_members_url")) __score0++;
            if (__jsonProps.Contains("organization.repos_url")) __score0++;
            if (__jsonProps.Contains("organization.url")) __score0++;
            if (__jsonProps.Contains("pull_request")) __score0++;
            if (__jsonProps.Contains("pull_request._links")) __score0++;
            if (__jsonProps.Contains("pull_request.active_lock_reason")) __score0++;
            if (__jsonProps.Contains("pull_request.additions")) __score0++;
            if (__jsonProps.Contains("pull_request.assignee")) __score0++;
            if (__jsonProps.Contains("pull_request.assignees")) __score0++;
            if (__jsonProps.Contains("pull_request.author_association")) __score0++;
            if (__jsonProps.Contains("pull_request.auto_merge")) __score0++;
            if (__jsonProps.Contains("pull_request.base")) __score0++;
            if (__jsonProps.Contains("pull_request.body")) __score0++;
            if (__jsonProps.Contains("pull_request.changed_files")) __score0++;
            if (__jsonProps.Contains("pull_request.closed_at")) __score0++;
            if (__jsonProps.Contains("pull_request.comments")) __score0++;
            if (__jsonProps.Contains("pull_request.comments_url")) __score0++;
            if (__jsonProps.Contains("pull_request.commits")) __score0++;
            if (__jsonProps.Contains("pull_request.commits_url")) __score0++;
            if (__jsonProps.Contains("pull_request.created_at")) __score0++;
            if (__jsonProps.Contains("pull_request.deletions")) __score0++;
            if (__jsonProps.Contains("pull_request.diff_url")) __score0++;
            if (__jsonProps.Contains("pull_request.draft")) __score0++;
            if (__jsonProps.Contains("pull_request.head")) __score0++;
            if (__jsonProps.Contains("pull_request.html_url")) __score0++;
            if (__jsonProps.Contains("pull_request.id")) __score0++;
            if (__jsonProps.Contains("pull_request.issue_url")) __score0++;
            if (__jsonProps.Contains("pull_request.labels")) __score0++;
            if (__jsonProps.Contains("pull_request.locked")) __score0++;
            if (__jsonProps.Contains("pull_request.maintainer_can_modify")) __score0++;
            if (__jsonProps.Contains("pull_request.merge_commit_sha")) __score0++;
            if (__jsonProps.Contains("pull_request.mergeable")) __score0++;
            if (__jsonProps.Contains("pull_request.mergeable_state")) __score0++;
            if (__jsonProps.Contains("pull_request.merged")) __score0++;
            if (__jsonProps.Contains("pull_request.merged_at")) __score0++;
            if (__jsonProps.Contains("pull_request.merged_by")) __score0++;
            if (__jsonProps.Contains("pull_request.milestone")) __score0++;
            if (__jsonProps.Contains("pull_request.node_id")) __score0++;
            if (__jsonProps.Contains("pull_request.number")) __score0++;
            if (__jsonProps.Contains("pull_request.patch_url")) __score0++;
            if (__jsonProps.Contains("pull_request.rebaseable")) __score0++;
            if (__jsonProps.Contains("pull_request.requested_reviewers")) __score0++;
            if (__jsonProps.Contains("pull_request.requested_teams")) __score0++;
            if (__jsonProps.Contains("pull_request.review_comment_url")) __score0++;
            if (__jsonProps.Contains("pull_request.review_comments")) __score0++;
            if (__jsonProps.Contains("pull_request.review_comments_url")) __score0++;
            if (__jsonProps.Contains("pull_request.state")) __score0++;
            if (__jsonProps.Contains("pull_request.statuses_url")) __score0++;
            if (__jsonProps.Contains("pull_request.title")) __score0++;
            if (__jsonProps.Contains("pull_request.updated_at")) __score0++;
            if (__jsonProps.Contains("pull_request.url")) __score0++;
            if (__jsonProps.Contains("pull_request.user")) __score0++;
            if (__jsonProps.Contains("repository")) __score0++;
            if (__jsonProps.Contains("repository.allow_auto_merge")) __score0++;
            if (__jsonProps.Contains("repository.allow_forking")) __score0++;
            if (__jsonProps.Contains("repository.allow_merge_commit")) __score0++;
            if (__jsonProps.Contains("repository.allow_rebase_merge")) __score0++;
            if (__jsonProps.Contains("repository.allow_squash_merge")) __score0++;
            if (__jsonProps.Contains("repository.allow_update_branch")) __score0++;
            if (__jsonProps.Contains("repository.anonymous_access_enabled")) __score0++;
            if (__jsonProps.Contains("repository.archive_url")) __score0++;
            if (__jsonProps.Contains("repository.archived")) __score0++;
            if (__jsonProps.Contains("repository.assignees_url")) __score0++;
            if (__jsonProps.Contains("repository.blobs_url")) __score0++;
            if (__jsonProps.Contains("repository.branches_url")) __score0++;
            if (__jsonProps.Contains("repository.clone_url")) __score0++;
            if (__jsonProps.Contains("repository.collaborators_url")) __score0++;
            if (__jsonProps.Contains("repository.comments_url")) __score0++;
            if (__jsonProps.Contains("repository.commits_url")) __score0++;
            if (__jsonProps.Contains("repository.compare_url")) __score0++;
            if (__jsonProps.Contains("repository.contents_url")) __score0++;
            if (__jsonProps.Contains("repository.contributors_url")) __score0++;
            if (__jsonProps.Contains("repository.created_at")) __score0++;
            if (__jsonProps.Contains("repository.custom_properties")) __score0++;
            if (__jsonProps.Contains("repository.default_branch")) __score0++;
            if (__jsonProps.Contains("repository.delete_branch_on_merge")) __score0++;
            if (__jsonProps.Contains("repository.deployments_url")) __score0++;
            if (__jsonProps.Contains("repository.description")) __score0++;
            if (__jsonProps.Contains("repository.disabled")) __score0++;
            if (__jsonProps.Contains("repository.downloads_url")) __score0++;
            if (__jsonProps.Contains("repository.events_url")) __score0++;
            if (__jsonProps.Contains("repository.fork")) __score0++;
            if (__jsonProps.Contains("repository.forks")) __score0++;
            if (__jsonProps.Contains("repository.forks_count")) __score0++;
            if (__jsonProps.Contains("repository.forks_url")) __score0++;
            if (__jsonProps.Contains("repository.full_name")) __score0++;
            if (__jsonProps.Contains("repository.git_commits_url")) __score0++;
            if (__jsonProps.Contains("repository.git_refs_url")) __score0++;
            if (__jsonProps.Contains("repository.git_tags_url")) __score0++;
            if (__jsonProps.Contains("repository.git_url")) __score0++;
            if (__jsonProps.Contains("repository.has_discussions")) __score0++;
            if (__jsonProps.Contains("repository.has_downloads")) __score0++;
            if (__jsonProps.Contains("repository.has_issues")) __score0++;
            if (__jsonProps.Contains("repository.has_pages")) __score0++;
            if (__jsonProps.Contains("repository.has_projects")) __score0++;
            if (__jsonProps.Contains("repository.has_wiki")) __score0++;
            if (__jsonProps.Contains("repository.homepage")) __score0++;
            if (__jsonProps.Contains("repository.hooks_url")) __score0++;
            if (__jsonProps.Contains("repository.html_url")) __score0++;
            if (__jsonProps.Contains("repository.id")) __score0++;
            if (__jsonProps.Contains("repository.is_template")) __score0++;
            if (__jsonProps.Contains("repository.issue_comment_url")) __score0++;
            if (__jsonProps.Contains("repository.issue_events_url")) __score0++;
            if (__jsonProps.Contains("repository.issues_url")) __score0++;
            if (__jsonProps.Contains("repository.keys_url")) __score0++;
            if (__jsonProps.Contains("repository.labels_url")) __score0++;
            if (__jsonProps.Contains("repository.language")) __score0++;
            if (__jsonProps.Contains("repository.languages_url")) __score0++;
            if (__jsonProps.Contains("repository.license")) __score0++;
            if (__jsonProps.Contains("repository.master_branch")) __score0++;
            if (__jsonProps.Contains("repository.merge_commit_message")) __score0++;
            if (__jsonProps.Contains("repository.merge_commit_title")) __score0++;
            if (__jsonProps.Contains("repository.merges_url")) __score0++;
            if (__jsonProps.Contains("repository.milestones_url")) __score0++;
            if (__jsonProps.Contains("repository.mirror_url")) __score0++;
            if (__jsonProps.Contains("repository.name")) __score0++;
            if (__jsonProps.Contains("repository.network_count")) __score0++;
            if (__jsonProps.Contains("repository.node_id")) __score0++;
            if (__jsonProps.Contains("repository.notifications_url")) __score0++;
            if (__jsonProps.Contains("repository.open_issues")) __score0++;
            if (__jsonProps.Contains("repository.open_issues_count")) __score0++;
            if (__jsonProps.Contains("repository.organization")) __score0++;
            if (__jsonProps.Contains("repository.owner")) __score0++;
            if (__jsonProps.Contains("repository.permissions")) __score0++;
            if (__jsonProps.Contains("repository.private")) __score0++;
            if (__jsonProps.Contains("repository.pulls_url")) __score0++;
            if (__jsonProps.Contains("repository.pushed_at")) __score0++;
            if (__jsonProps.Contains("repository.releases_url")) __score0++;
            if (__jsonProps.Contains("repository.size")) __score0++;
            if (__jsonProps.Contains("repository.squash_merge_commit_message")) __score0++;
            if (__jsonProps.Contains("repository.squash_merge_commit_title")) __score0++;
            if (__jsonProps.Contains("repository.ssh_url")) __score0++;
            if (__jsonProps.Contains("repository.stargazers_count")) __score0++;
            if (__jsonProps.Contains("repository.stargazers_url")) __score0++;
            if (__jsonProps.Contains("repository.starred_at")) __score0++;
            if (__jsonProps.Contains("repository.statuses_url")) __score0++;
            if (__jsonProps.Contains("repository.subscribers_count")) __score0++;
            if (__jsonProps.Contains("repository.subscribers_url")) __score0++;
            if (__jsonProps.Contains("repository.subscription_url")) __score0++;
            if (__jsonProps.Contains("repository.svn_url")) __score0++;
            if (__jsonProps.Contains("repository.tags_url")) __score0++;
            if (__jsonProps.Contains("repository.teams_url")) __score0++;
            if (__jsonProps.Contains("repository.temp_clone_token")) __score0++;
            if (__jsonProps.Contains("repository.template_repository")) __score0++;
            if (__jsonProps.Contains("repository.topics")) __score0++;
            if (__jsonProps.Contains("repository.trees_url")) __score0++;
            if (__jsonProps.Contains("repository.updated_at")) __score0++;
            if (__jsonProps.Contains("repository.url")) __score0++;
            if (__jsonProps.Contains("repository.use_squash_pr_title_as_default")) __score0++;
            if (__jsonProps.Contains("repository.visibility")) __score0++;
            if (__jsonProps.Contains("repository.watchers")) __score0++;
            if (__jsonProps.Contains("repository.watchers_count")) __score0++;
            if (__jsonProps.Contains("repository.web_commit_signoff_required")) __score0++;
            if (__jsonProps.Contains("requested_reviewer")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.avatar_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.deleted")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.email")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.events_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.followers_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.following_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.gists_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.gravatar_id")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.html_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.id")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.login")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.name")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.node_id")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.organizations_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.received_events_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.repos_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.site_admin")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.starred_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.type")) __score0++;
            if (__jsonProps.Contains("requested_reviewer.url")) __score0++;
            if (__jsonProps.Contains("sender")) __score0++;
            if (__jsonProps.Contains("sender.avatar_url")) __score0++;
            if (__jsonProps.Contains("sender.email")) __score0++;
            if (__jsonProps.Contains("sender.events_url")) __score0++;
            if (__jsonProps.Contains("sender.followers_url")) __score0++;
            if (__jsonProps.Contains("sender.following_url")) __score0++;
            if (__jsonProps.Contains("sender.gists_url")) __score0++;
            if (__jsonProps.Contains("sender.gravatar_id")) __score0++;
            if (__jsonProps.Contains("sender.html_url")) __score0++;
            if (__jsonProps.Contains("sender.id")) __score0++;
            if (__jsonProps.Contains("sender.login")) __score0++;
            if (__jsonProps.Contains("sender.name")) __score0++;
            if (__jsonProps.Contains("sender.node_id")) __score0++;
            if (__jsonProps.Contains("sender.organizations_url")) __score0++;
            if (__jsonProps.Contains("sender.received_events_url")) __score0++;
            if (__jsonProps.Contains("sender.repos_url")) __score0++;
            if (__jsonProps.Contains("sender.site_admin")) __score0++;
            if (__jsonProps.Contains("sender.starred_at")) __score0++;
            if (__jsonProps.Contains("sender.starred_url")) __score0++;
            if (__jsonProps.Contains("sender.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("sender.type")) __score0++;
            if (__jsonProps.Contains("sender.url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("action")) __score1++;
            if (__jsonProps.Contains("enterprise")) __score1++;
            if (__jsonProps.Contains("enterprise.avatar_url")) __score1++;
            if (__jsonProps.Contains("enterprise.created_at")) __score1++;
            if (__jsonProps.Contains("enterprise.description")) __score1++;
            if (__jsonProps.Contains("enterprise.html_url")) __score1++;
            if (__jsonProps.Contains("enterprise.id")) __score1++;
            if (__jsonProps.Contains("enterprise.name")) __score1++;
            if (__jsonProps.Contains("enterprise.node_id")) __score1++;
            if (__jsonProps.Contains("enterprise.slug")) __score1++;
            if (__jsonProps.Contains("enterprise.updated_at")) __score1++;
            if (__jsonProps.Contains("enterprise.website_url")) __score1++;
            if (__jsonProps.Contains("installation")) __score1++;
            if (__jsonProps.Contains("installation.id")) __score1++;
            if (__jsonProps.Contains("installation.node_id")) __score1++;
            if (__jsonProps.Contains("number")) __score1++;
            if (__jsonProps.Contains("organization")) __score1++;
            if (__jsonProps.Contains("organization.avatar_url")) __score1++;
            if (__jsonProps.Contains("organization.description")) __score1++;
            if (__jsonProps.Contains("organization.events_url")) __score1++;
            if (__jsonProps.Contains("organization.hooks_url")) __score1++;
            if (__jsonProps.Contains("organization.id")) __score1++;
            if (__jsonProps.Contains("organization.issues_url")) __score1++;
            if (__jsonProps.Contains("organization.login")) __score1++;
            if (__jsonProps.Contains("organization.members_url")) __score1++;
            if (__jsonProps.Contains("organization.node_id")) __score1++;
            if (__jsonProps.Contains("organization.public_members_url")) __score1++;
            if (__jsonProps.Contains("organization.repos_url")) __score1++;
            if (__jsonProps.Contains("organization.url")) __score1++;
            if (__jsonProps.Contains("pull_request")) __score1++;
            if (__jsonProps.Contains("pull_request._links")) __score1++;
            if (__jsonProps.Contains("pull_request.active_lock_reason")) __score1++;
            if (__jsonProps.Contains("pull_request.additions")) __score1++;
            if (__jsonProps.Contains("pull_request.assignee")) __score1++;
            if (__jsonProps.Contains("pull_request.assignees")) __score1++;
            if (__jsonProps.Contains("pull_request.author_association")) __score1++;
            if (__jsonProps.Contains("pull_request.auto_merge")) __score1++;
            if (__jsonProps.Contains("pull_request.base")) __score1++;
            if (__jsonProps.Contains("pull_request.body")) __score1++;
            if (__jsonProps.Contains("pull_request.changed_files")) __score1++;
            if (__jsonProps.Contains("pull_request.closed_at")) __score1++;
            if (__jsonProps.Contains("pull_request.comments")) __score1++;
            if (__jsonProps.Contains("pull_request.comments_url")) __score1++;
            if (__jsonProps.Contains("pull_request.commits")) __score1++;
            if (__jsonProps.Contains("pull_request.commits_url")) __score1++;
            if (__jsonProps.Contains("pull_request.created_at")) __score1++;
            if (__jsonProps.Contains("pull_request.deletions")) __score1++;
            if (__jsonProps.Contains("pull_request.diff_url")) __score1++;
            if (__jsonProps.Contains("pull_request.draft")) __score1++;
            if (__jsonProps.Contains("pull_request.head")) __score1++;
            if (__jsonProps.Contains("pull_request.html_url")) __score1++;
            if (__jsonProps.Contains("pull_request.id")) __score1++;
            if (__jsonProps.Contains("pull_request.issue_url")) __score1++;
            if (__jsonProps.Contains("pull_request.labels")) __score1++;
            if (__jsonProps.Contains("pull_request.locked")) __score1++;
            if (__jsonProps.Contains("pull_request.maintainer_can_modify")) __score1++;
            if (__jsonProps.Contains("pull_request.merge_commit_sha")) __score1++;
            if (__jsonProps.Contains("pull_request.mergeable")) __score1++;
            if (__jsonProps.Contains("pull_request.mergeable_state")) __score1++;
            if (__jsonProps.Contains("pull_request.merged")) __score1++;
            if (__jsonProps.Contains("pull_request.merged_at")) __score1++;
            if (__jsonProps.Contains("pull_request.merged_by")) __score1++;
            if (__jsonProps.Contains("pull_request.milestone")) __score1++;
            if (__jsonProps.Contains("pull_request.node_id")) __score1++;
            if (__jsonProps.Contains("pull_request.number")) __score1++;
            if (__jsonProps.Contains("pull_request.patch_url")) __score1++;
            if (__jsonProps.Contains("pull_request.rebaseable")) __score1++;
            if (__jsonProps.Contains("pull_request.requested_reviewers")) __score1++;
            if (__jsonProps.Contains("pull_request.requested_teams")) __score1++;
            if (__jsonProps.Contains("pull_request.review_comment_url")) __score1++;
            if (__jsonProps.Contains("pull_request.review_comments")) __score1++;
            if (__jsonProps.Contains("pull_request.review_comments_url")) __score1++;
            if (__jsonProps.Contains("pull_request.state")) __score1++;
            if (__jsonProps.Contains("pull_request.statuses_url")) __score1++;
            if (__jsonProps.Contains("pull_request.title")) __score1++;
            if (__jsonProps.Contains("pull_request.updated_at")) __score1++;
            if (__jsonProps.Contains("pull_request.url")) __score1++;
            if (__jsonProps.Contains("pull_request.user")) __score1++;
            if (__jsonProps.Contains("repository")) __score1++;
            if (__jsonProps.Contains("repository.allow_auto_merge")) __score1++;
            if (__jsonProps.Contains("repository.allow_forking")) __score1++;
            if (__jsonProps.Contains("repository.allow_merge_commit")) __score1++;
            if (__jsonProps.Contains("repository.allow_rebase_merge")) __score1++;
            if (__jsonProps.Contains("repository.allow_squash_merge")) __score1++;
            if (__jsonProps.Contains("repository.allow_update_branch")) __score1++;
            if (__jsonProps.Contains("repository.anonymous_access_enabled")) __score1++;
            if (__jsonProps.Contains("repository.archive_url")) __score1++;
            if (__jsonProps.Contains("repository.archived")) __score1++;
            if (__jsonProps.Contains("repository.assignees_url")) __score1++;
            if (__jsonProps.Contains("repository.blobs_url")) __score1++;
            if (__jsonProps.Contains("repository.branches_url")) __score1++;
            if (__jsonProps.Contains("repository.clone_url")) __score1++;
            if (__jsonProps.Contains("repository.collaborators_url")) __score1++;
            if (__jsonProps.Contains("repository.comments_url")) __score1++;
            if (__jsonProps.Contains("repository.commits_url")) __score1++;
            if (__jsonProps.Contains("repository.compare_url")) __score1++;
            if (__jsonProps.Contains("repository.contents_url")) __score1++;
            if (__jsonProps.Contains("repository.contributors_url")) __score1++;
            if (__jsonProps.Contains("repository.created_at")) __score1++;
            if (__jsonProps.Contains("repository.custom_properties")) __score1++;
            if (__jsonProps.Contains("repository.default_branch")) __score1++;
            if (__jsonProps.Contains("repository.delete_branch_on_merge")) __score1++;
            if (__jsonProps.Contains("repository.deployments_url")) __score1++;
            if (__jsonProps.Contains("repository.description")) __score1++;
            if (__jsonProps.Contains("repository.disabled")) __score1++;
            if (__jsonProps.Contains("repository.downloads_url")) __score1++;
            if (__jsonProps.Contains("repository.events_url")) __score1++;
            if (__jsonProps.Contains("repository.fork")) __score1++;
            if (__jsonProps.Contains("repository.forks")) __score1++;
            if (__jsonProps.Contains("repository.forks_count")) __score1++;
            if (__jsonProps.Contains("repository.forks_url")) __score1++;
            if (__jsonProps.Contains("repository.full_name")) __score1++;
            if (__jsonProps.Contains("repository.git_commits_url")) __score1++;
            if (__jsonProps.Contains("repository.git_refs_url")) __score1++;
            if (__jsonProps.Contains("repository.git_tags_url")) __score1++;
            if (__jsonProps.Contains("repository.git_url")) __score1++;
            if (__jsonProps.Contains("repository.has_discussions")) __score1++;
            if (__jsonProps.Contains("repository.has_downloads")) __score1++;
            if (__jsonProps.Contains("repository.has_issues")) __score1++;
            if (__jsonProps.Contains("repository.has_pages")) __score1++;
            if (__jsonProps.Contains("repository.has_projects")) __score1++;
            if (__jsonProps.Contains("repository.has_wiki")) __score1++;
            if (__jsonProps.Contains("repository.homepage")) __score1++;
            if (__jsonProps.Contains("repository.hooks_url")) __score1++;
            if (__jsonProps.Contains("repository.html_url")) __score1++;
            if (__jsonProps.Contains("repository.id")) __score1++;
            if (__jsonProps.Contains("repository.is_template")) __score1++;
            if (__jsonProps.Contains("repository.issue_comment_url")) __score1++;
            if (__jsonProps.Contains("repository.issue_events_url")) __score1++;
            if (__jsonProps.Contains("repository.issues_url")) __score1++;
            if (__jsonProps.Contains("repository.keys_url")) __score1++;
            if (__jsonProps.Contains("repository.labels_url")) __score1++;
            if (__jsonProps.Contains("repository.language")) __score1++;
            if (__jsonProps.Contains("repository.languages_url")) __score1++;
            if (__jsonProps.Contains("repository.license")) __score1++;
            if (__jsonProps.Contains("repository.master_branch")) __score1++;
            if (__jsonProps.Contains("repository.merge_commit_message")) __score1++;
            if (__jsonProps.Contains("repository.merge_commit_title")) __score1++;
            if (__jsonProps.Contains("repository.merges_url")) __score1++;
            if (__jsonProps.Contains("repository.milestones_url")) __score1++;
            if (__jsonProps.Contains("repository.mirror_url")) __score1++;
            if (__jsonProps.Contains("repository.name")) __score1++;
            if (__jsonProps.Contains("repository.network_count")) __score1++;
            if (__jsonProps.Contains("repository.node_id")) __score1++;
            if (__jsonProps.Contains("repository.notifications_url")) __score1++;
            if (__jsonProps.Contains("repository.open_issues")) __score1++;
            if (__jsonProps.Contains("repository.open_issues_count")) __score1++;
            if (__jsonProps.Contains("repository.organization")) __score1++;
            if (__jsonProps.Contains("repository.owner")) __score1++;
            if (__jsonProps.Contains("repository.permissions")) __score1++;
            if (__jsonProps.Contains("repository.private")) __score1++;
            if (__jsonProps.Contains("repository.pulls_url")) __score1++;
            if (__jsonProps.Contains("repository.pushed_at")) __score1++;
            if (__jsonProps.Contains("repository.releases_url")) __score1++;
            if (__jsonProps.Contains("repository.size")) __score1++;
            if (__jsonProps.Contains("repository.squash_merge_commit_message")) __score1++;
            if (__jsonProps.Contains("repository.squash_merge_commit_title")) __score1++;
            if (__jsonProps.Contains("repository.ssh_url")) __score1++;
            if (__jsonProps.Contains("repository.stargazers_count")) __score1++;
            if (__jsonProps.Contains("repository.stargazers_url")) __score1++;
            if (__jsonProps.Contains("repository.starred_at")) __score1++;
            if (__jsonProps.Contains("repository.statuses_url")) __score1++;
            if (__jsonProps.Contains("repository.subscribers_count")) __score1++;
            if (__jsonProps.Contains("repository.subscribers_url")) __score1++;
            if (__jsonProps.Contains("repository.subscription_url")) __score1++;
            if (__jsonProps.Contains("repository.svn_url")) __score1++;
            if (__jsonProps.Contains("repository.tags_url")) __score1++;
            if (__jsonProps.Contains("repository.teams_url")) __score1++;
            if (__jsonProps.Contains("repository.temp_clone_token")) __score1++;
            if (__jsonProps.Contains("repository.template_repository")) __score1++;
            if (__jsonProps.Contains("repository.topics")) __score1++;
            if (__jsonProps.Contains("repository.trees_url")) __score1++;
            if (__jsonProps.Contains("repository.updated_at")) __score1++;
            if (__jsonProps.Contains("repository.url")) __score1++;
            if (__jsonProps.Contains("repository.use_squash_pr_title_as_default")) __score1++;
            if (__jsonProps.Contains("repository.visibility")) __score1++;
            if (__jsonProps.Contains("repository.watchers")) __score1++;
            if (__jsonProps.Contains("repository.watchers_count")) __score1++;
            if (__jsonProps.Contains("repository.web_commit_signoff_required")) __score1++;
            if (__jsonProps.Contains("requested_team")) __score1++;
            if (__jsonProps.Contains("requested_team.deleted")) __score1++;
            if (__jsonProps.Contains("requested_team.description")) __score1++;
            if (__jsonProps.Contains("requested_team.html_url")) __score1++;
            if (__jsonProps.Contains("requested_team.id")) __score1++;
            if (__jsonProps.Contains("requested_team.members_url")) __score1++;
            if (__jsonProps.Contains("requested_team.name")) __score1++;
            if (__jsonProps.Contains("requested_team.node_id")) __score1++;
            if (__jsonProps.Contains("requested_team.parent")) __score1++;
            if (__jsonProps.Contains("requested_team.permission")) __score1++;
            if (__jsonProps.Contains("requested_team.privacy")) __score1++;
            if (__jsonProps.Contains("requested_team.repositories_url")) __score1++;
            if (__jsonProps.Contains("requested_team.slug")) __score1++;
            if (__jsonProps.Contains("requested_team.url")) __score1++;
            if (__jsonProps.Contains("sender")) __score1++;
            if (__jsonProps.Contains("sender.avatar_url")) __score1++;
            if (__jsonProps.Contains("sender.email")) __score1++;
            if (__jsonProps.Contains("sender.events_url")) __score1++;
            if (__jsonProps.Contains("sender.followers_url")) __score1++;
            if (__jsonProps.Contains("sender.following_url")) __score1++;
            if (__jsonProps.Contains("sender.gists_url")) __score1++;
            if (__jsonProps.Contains("sender.gravatar_id")) __score1++;
            if (__jsonProps.Contains("sender.html_url")) __score1++;
            if (__jsonProps.Contains("sender.id")) __score1++;
            if (__jsonProps.Contains("sender.login")) __score1++;
            if (__jsonProps.Contains("sender.name")) __score1++;
            if (__jsonProps.Contains("sender.node_id")) __score1++;
            if (__jsonProps.Contains("sender.organizations_url")) __score1++;
            if (__jsonProps.Contains("sender.received_events_url")) __score1++;
            if (__jsonProps.Contains("sender.repos_url")) __score1++;
            if (__jsonProps.Contains("sender.site_admin")) __score1++;
            if (__jsonProps.Contains("sender.starred_at")) __score1++;
            if (__jsonProps.Contains("sender.starred_url")) __score1++;
            if (__jsonProps.Contains("sender.subscriptions_url")) __score1++;
            if (__jsonProps.Contains("sender.type")) __score1++;
            if (__jsonProps.Contains("sender.url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.WebhookPullRequestReviewRequestedVariant1? webhookPullRequestReviewRequestedVariant1 = default;
            global::G.WebhookPullRequestReviewRequestedVariant2? webhookPullRequestReviewRequestedVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestedVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestedVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestedVariant1).Name}");
                        webhookPullRequestReviewRequestedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestedVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestedVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestedVariant2).Name}");
                        webhookPullRequestReviewRequestedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (webhookPullRequestReviewRequestedVariant1 == null && webhookPullRequestReviewRequestedVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestedVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestedVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestedVariant1).Name}");
                    webhookPullRequestReviewRequestedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (webhookPullRequestReviewRequestedVariant1 == null && webhookPullRequestReviewRequestedVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestedVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestedVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestedVariant2).Name}");
                    webhookPullRequestReviewRequestedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.WebhookPullRequestReviewRequested(
                webhookPullRequestReviewRequestedVariant1,

                webhookPullRequestReviewRequestedVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewRequested value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhookPullRequestReviewRequestedVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestedVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestedVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestedVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookPullRequestReviewRequestedVariant1!, typeInfo);
            }
            else if (value.IsWebhookPullRequestReviewRequestedVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestedVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestedVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestedVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookPullRequestReviewRequestedVariant2!, typeInfo);
            }
        }
    }
}