//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppEvents
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
        SecurityAndAnalysis,
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
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "security_and_analysis" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis,
                "reminder" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.Reminder,
                "pull_request_review_thread" => WebhookIssuesClosedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}