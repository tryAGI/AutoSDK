//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "security_and_analysis" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis,
                "pull_request_review_thread" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                "reminder" => WebhookIssuesOpenedIssuePerformedViaGithubAppEvents.Reminder,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}