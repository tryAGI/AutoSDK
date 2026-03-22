//HintName: G.Models.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent
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
        SecurityAndAnalysis,
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
    public static class WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewThread,
                "push" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Release,
                "reminder" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Reminder,
                "repository" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert,
                "security_and_analysis" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.SecurityAndAnalysis,
                "star" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}