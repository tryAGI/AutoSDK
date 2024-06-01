//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Reminder,
                "pull_request_review_thread" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}