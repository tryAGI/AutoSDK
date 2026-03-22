//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                "push" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Release,
                "reminder" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Reminder,
                "repository" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "security_and_analysis" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis,
                "star" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesEditedIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}