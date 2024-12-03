//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis => "security_and_analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Reminder,
                "security_and_analysis" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis,
                _ => null,
            };
        }
    }
}