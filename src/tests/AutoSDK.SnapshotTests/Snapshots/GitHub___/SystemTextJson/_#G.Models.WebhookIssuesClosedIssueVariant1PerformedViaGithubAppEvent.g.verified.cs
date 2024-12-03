//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun,
                "security_and_analysis" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.SecurityAndAnalysis,
                "reminder" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.Reminder,
                "pull_request_review_thread" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}