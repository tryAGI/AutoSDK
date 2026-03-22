//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                "push" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Release,
                "reminder" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Reminder,
                "repository" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "security_and_analysis" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis,
                "star" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}