//HintName: G.JsonConverters.PullRequestWebhook.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PullRequestWebhookJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PullRequestWebhook>
    {
        /// <inheritdoc />
        public override global::G.PullRequestWebhook Read(
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
            if (__jsonProps.Contains("_links")) __score0++;
            if (__jsonProps.Contains("_links.comments")) __score0++;
            if (__jsonProps.Contains("_links.commits")) __score0++;
            if (__jsonProps.Contains("_links.html")) __score0++;
            if (__jsonProps.Contains("_links.issue")) __score0++;
            if (__jsonProps.Contains("_links.review_comment")) __score0++;
            if (__jsonProps.Contains("_links.review_comments")) __score0++;
            if (__jsonProps.Contains("_links.self")) __score0++;
            if (__jsonProps.Contains("_links.statuses")) __score0++;
            if (__jsonProps.Contains("active_lock_reason")) __score0++;
            if (__jsonProps.Contains("additions")) __score0++;
            if (__jsonProps.Contains("assignee")) __score0++;
            if (__jsonProps.Contains("assignee.avatar_url")) __score0++;
            if (__jsonProps.Contains("assignee.email")) __score0++;
            if (__jsonProps.Contains("assignee.events_url")) __score0++;
            if (__jsonProps.Contains("assignee.followers_url")) __score0++;
            if (__jsonProps.Contains("assignee.following_url")) __score0++;
            if (__jsonProps.Contains("assignee.gists_url")) __score0++;
            if (__jsonProps.Contains("assignee.gravatar_id")) __score0++;
            if (__jsonProps.Contains("assignee.html_url")) __score0++;
            if (__jsonProps.Contains("assignee.id")) __score0++;
            if (__jsonProps.Contains("assignee.login")) __score0++;
            if (__jsonProps.Contains("assignee.name")) __score0++;
            if (__jsonProps.Contains("assignee.node_id")) __score0++;
            if (__jsonProps.Contains("assignee.organizations_url")) __score0++;
            if (__jsonProps.Contains("assignee.received_events_url")) __score0++;
            if (__jsonProps.Contains("assignee.repos_url")) __score0++;
            if (__jsonProps.Contains("assignee.site_admin")) __score0++;
            if (__jsonProps.Contains("assignee.starred_at")) __score0++;
            if (__jsonProps.Contains("assignee.starred_url")) __score0++;
            if (__jsonProps.Contains("assignee.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("assignee.type")) __score0++;
            if (__jsonProps.Contains("assignee.url")) __score0++;
            if (__jsonProps.Contains("assignees")) __score0++;
            if (__jsonProps.Contains("author_association")) __score0++;
            if (__jsonProps.Contains("auto_merge")) __score0++;
            if (__jsonProps.Contains("auto_merge.commit_message")) __score0++;
            if (__jsonProps.Contains("auto_merge.commit_title")) __score0++;
            if (__jsonProps.Contains("auto_merge.enabled_by")) __score0++;
            if (__jsonProps.Contains("auto_merge.merge_method")) __score0++;
            if (__jsonProps.Contains("base")) __score0++;
            if (__jsonProps.Contains("base.label")) __score0++;
            if (__jsonProps.Contains("base.ref")) __score0++;
            if (__jsonProps.Contains("base.repo")) __score0++;
            if (__jsonProps.Contains("base.sha")) __score0++;
            if (__jsonProps.Contains("base.user")) __score0++;
            if (__jsonProps.Contains("body")) __score0++;
            if (__jsonProps.Contains("changed_files")) __score0++;
            if (__jsonProps.Contains("closed_at")) __score0++;
            if (__jsonProps.Contains("comments")) __score0++;
            if (__jsonProps.Contains("comments_url")) __score0++;
            if (__jsonProps.Contains("commits")) __score0++;
            if (__jsonProps.Contains("commits_url")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("deletions")) __score0++;
            if (__jsonProps.Contains("diff_url")) __score0++;
            if (__jsonProps.Contains("draft")) __score0++;
            if (__jsonProps.Contains("head")) __score0++;
            if (__jsonProps.Contains("head.label")) __score0++;
            if (__jsonProps.Contains("head.ref")) __score0++;
            if (__jsonProps.Contains("head.repo")) __score0++;
            if (__jsonProps.Contains("head.sha")) __score0++;
            if (__jsonProps.Contains("head.user")) __score0++;
            if (__jsonProps.Contains("html_url")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("issue_url")) __score0++;
            if (__jsonProps.Contains("labels")) __score0++;
            if (__jsonProps.Contains("locked")) __score0++;
            if (__jsonProps.Contains("maintainer_can_modify")) __score0++;
            if (__jsonProps.Contains("merge_commit_sha")) __score0++;
            if (__jsonProps.Contains("mergeable")) __score0++;
            if (__jsonProps.Contains("mergeable_state")) __score0++;
            if (__jsonProps.Contains("merged")) __score0++;
            if (__jsonProps.Contains("merged_at")) __score0++;
            if (__jsonProps.Contains("merged_by")) __score0++;
            if (__jsonProps.Contains("merged_by.avatar_url")) __score0++;
            if (__jsonProps.Contains("merged_by.email")) __score0++;
            if (__jsonProps.Contains("merged_by.events_url")) __score0++;
            if (__jsonProps.Contains("merged_by.followers_url")) __score0++;
            if (__jsonProps.Contains("merged_by.following_url")) __score0++;
            if (__jsonProps.Contains("merged_by.gists_url")) __score0++;
            if (__jsonProps.Contains("merged_by.gravatar_id")) __score0++;
            if (__jsonProps.Contains("merged_by.html_url")) __score0++;
            if (__jsonProps.Contains("merged_by.id")) __score0++;
            if (__jsonProps.Contains("merged_by.login")) __score0++;
            if (__jsonProps.Contains("merged_by.name")) __score0++;
            if (__jsonProps.Contains("merged_by.node_id")) __score0++;
            if (__jsonProps.Contains("merged_by.organizations_url")) __score0++;
            if (__jsonProps.Contains("merged_by.received_events_url")) __score0++;
            if (__jsonProps.Contains("merged_by.repos_url")) __score0++;
            if (__jsonProps.Contains("merged_by.site_admin")) __score0++;
            if (__jsonProps.Contains("merged_by.starred_at")) __score0++;
            if (__jsonProps.Contains("merged_by.starred_url")) __score0++;
            if (__jsonProps.Contains("merged_by.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("merged_by.type")) __score0++;
            if (__jsonProps.Contains("merged_by.url")) __score0++;
            if (__jsonProps.Contains("milestone")) __score0++;
            if (__jsonProps.Contains("milestone.closed_at")) __score0++;
            if (__jsonProps.Contains("milestone.closed_issues")) __score0++;
            if (__jsonProps.Contains("milestone.created_at")) __score0++;
            if (__jsonProps.Contains("milestone.creator")) __score0++;
            if (__jsonProps.Contains("milestone.description")) __score0++;
            if (__jsonProps.Contains("milestone.due_on")) __score0++;
            if (__jsonProps.Contains("milestone.html_url")) __score0++;
            if (__jsonProps.Contains("milestone.id")) __score0++;
            if (__jsonProps.Contains("milestone.labels_url")) __score0++;
            if (__jsonProps.Contains("milestone.node_id")) __score0++;
            if (__jsonProps.Contains("milestone.number")) __score0++;
            if (__jsonProps.Contains("milestone.open_issues")) __score0++;
            if (__jsonProps.Contains("milestone.state")) __score0++;
            if (__jsonProps.Contains("milestone.title")) __score0++;
            if (__jsonProps.Contains("milestone.updated_at")) __score0++;
            if (__jsonProps.Contains("milestone.url")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("number")) __score0++;
            if (__jsonProps.Contains("patch_url")) __score0++;
            if (__jsonProps.Contains("rebaseable")) __score0++;
            if (__jsonProps.Contains("requested_reviewers")) __score0++;
            if (__jsonProps.Contains("requested_teams")) __score0++;
            if (__jsonProps.Contains("review_comment_url")) __score0++;
            if (__jsonProps.Contains("review_comments")) __score0++;
            if (__jsonProps.Contains("review_comments_url")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("statuses_url")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            if (__jsonProps.Contains("user")) __score0++;
            if (__jsonProps.Contains("user.avatar_url")) __score0++;
            if (__jsonProps.Contains("user.email")) __score0++;
            if (__jsonProps.Contains("user.events_url")) __score0++;
            if (__jsonProps.Contains("user.followers_url")) __score0++;
            if (__jsonProps.Contains("user.following_url")) __score0++;
            if (__jsonProps.Contains("user.gists_url")) __score0++;
            if (__jsonProps.Contains("user.gravatar_id")) __score0++;
            if (__jsonProps.Contains("user.html_url")) __score0++;
            if (__jsonProps.Contains("user.id")) __score0++;
            if (__jsonProps.Contains("user.login")) __score0++;
            if (__jsonProps.Contains("user.name")) __score0++;
            if (__jsonProps.Contains("user.node_id")) __score0++;
            if (__jsonProps.Contains("user.organizations_url")) __score0++;
            if (__jsonProps.Contains("user.received_events_url")) __score0++;
            if (__jsonProps.Contains("user.repos_url")) __score0++;
            if (__jsonProps.Contains("user.site_admin")) __score0++;
            if (__jsonProps.Contains("user.starred_at")) __score0++;
            if (__jsonProps.Contains("user.starred_url")) __score0++;
            if (__jsonProps.Contains("user.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("user.type")) __score0++;
            if (__jsonProps.Contains("user.url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("allow_auto_merge")) __score1++;
            if (__jsonProps.Contains("allow_update_branch")) __score1++;
            if (__jsonProps.Contains("delete_branch_on_merge")) __score1++;
            if (__jsonProps.Contains("merge_commit_message")) __score1++;
            if (__jsonProps.Contains("merge_commit_title")) __score1++;
            if (__jsonProps.Contains("squash_merge_commit_message")) __score1++;
            if (__jsonProps.Contains("squash_merge_commit_title")) __score1++;
            if (__jsonProps.Contains("use_squash_pr_title_as_default")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.PullRequest? pullRequest = default;
            global::G.PullRequestWebhookVariant2? pullRequestWebhookVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullRequest).Name}");
                        pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PullRequestWebhookVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullRequestWebhookVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullRequestWebhookVariant2).Name}");
                        pullRequestWebhookVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pullRequest == null && pullRequestWebhookVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullRequest).Name}");
                    pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PullRequestWebhookVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullRequestWebhookVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullRequestWebhookVariant2).Name}");
                    pullRequestWebhookVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PullRequestWebhook(
                pullRequest,

                pullRequestWebhookVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PullRequestWebhook value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequest!, typeInfo);
            }
            else if (value.IsPullRequestWebhookVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PullRequestWebhookVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullRequestWebhookVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullRequestWebhookVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestWebhookVariant2!, typeInfo);
            }
        }
    }
}