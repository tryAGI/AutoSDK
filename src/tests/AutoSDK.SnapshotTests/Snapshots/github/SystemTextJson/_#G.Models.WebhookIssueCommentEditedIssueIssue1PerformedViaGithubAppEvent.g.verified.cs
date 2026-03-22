//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent
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
        DeployKey,
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
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        Issues,
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
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
        PullRequestReviewThread,
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
        Reminder,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewThread,
                "push" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Release,
                "reminder" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Reminder,
                "repository" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}