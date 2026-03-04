//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent
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
    public static class WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.Reminder,
                "pull_request_review_thread" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}