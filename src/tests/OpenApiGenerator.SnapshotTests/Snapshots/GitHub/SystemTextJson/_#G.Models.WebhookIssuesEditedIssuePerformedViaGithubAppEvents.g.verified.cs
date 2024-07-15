//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppEvents
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
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        Reminder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "security_and_analysis" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis,
                "pull_request_review_thread" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                "reminder" => WebhookIssuesEditedIssuePerformedViaGithubAppEvents.Reminder,
                _ => null,
            };
        }
    }
}