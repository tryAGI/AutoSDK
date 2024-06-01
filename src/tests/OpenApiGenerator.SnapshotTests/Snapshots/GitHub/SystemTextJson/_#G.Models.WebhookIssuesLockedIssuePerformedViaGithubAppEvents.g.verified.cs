//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppEvents
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
        SecurityAndAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis => "security_and_analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.Reminder,
                "security_and_analysis" => WebhookIssuesLockedIssuePerformedViaGithubAppEvents.SecurityAndAnalysis,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}