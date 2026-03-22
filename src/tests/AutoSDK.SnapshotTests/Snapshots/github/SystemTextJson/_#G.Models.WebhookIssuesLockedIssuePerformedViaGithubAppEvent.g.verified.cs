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
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Organization => "organization",
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
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
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
                "deploy_key" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Organization,
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
                "reminder" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Reminder,
                "repository" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "security_and_analysis" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.SecurityAndAnalysis,
                "star" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesLockedIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}