//HintName: G.Models.WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents
    {
        /// <summary>
        /// 
        /// </summary>
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        ContentReference,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        DeploymentReview,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        Fork,
        /// <summary>
        /// 
        /// </summary>
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        Issues,
        /// <summary>
        /// 
        /// </summary>
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        Label,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Membership,
        /// <summary>
        /// 
        /// </summary>
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        Release,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        Star,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        Watch,
        /// <summary>
        /// 
        /// </summary>
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        WorkflowRun,
        /// <summary>
        /// 
        /// </summary>
        Reminder,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.Reminder,
                "pull_request_review_thread" => WebhookIssueCommentEditedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}