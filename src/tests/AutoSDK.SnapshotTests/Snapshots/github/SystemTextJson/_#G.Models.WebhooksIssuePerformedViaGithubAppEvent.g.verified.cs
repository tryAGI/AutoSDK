//HintName: G.Models.WebhooksIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssuePerformedViaGithubAppEvent
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
    public static class WebhooksIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhooksIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhooksIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhooksIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhooksIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhooksIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhooksIssuePerformedViaGithubAppEvent.Create => "create",
                WebhooksIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhooksIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhooksIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhooksIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhooksIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhooksIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhooksIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhooksIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhooksIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhooksIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhooksIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhooksIssuePerformedViaGithubAppEvent.Label => "label",
                WebhooksIssuePerformedViaGithubAppEvent.Member => "member",
                WebhooksIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhooksIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhooksIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhooksIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhooksIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhooksIssuePerformedViaGithubAppEvent.Project => "project",
                WebhooksIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhooksIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhooksIssuePerformedViaGithubAppEvent.Public => "public",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhooksIssuePerformedViaGithubAppEvent.Push => "push",
                WebhooksIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhooksIssuePerformedViaGithubAppEvent.Release => "release",
                WebhooksIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                WebhooksIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhooksIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhooksIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhooksIssuePerformedViaGithubAppEvent.Star => "star",
                WebhooksIssuePerformedViaGithubAppEvent.Status => "status",
                WebhooksIssuePerformedViaGithubAppEvent.Team => "team",
                WebhooksIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhooksIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhooksIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhooksIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhooksIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhooksIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhooksIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhooksIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhooksIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhooksIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhooksIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhooksIssuePerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhooksIssuePerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhooksIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhooksIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhooksIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhooksIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhooksIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhooksIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhooksIssuePerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhooksIssuePerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhooksIssuePerformedViaGithubAppEvent.Issues,
                "label" => WebhooksIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhooksIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhooksIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhooksIssuePerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhooksIssuePerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhooksIssuePerformedViaGithubAppEvent.Organization,
                "page_build" => WebhooksIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhooksIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhooksIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhooksIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhooksIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhooksIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhooksIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                "push" => WebhooksIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhooksIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhooksIssuePerformedViaGithubAppEvent.Release,
                "reminder" => WebhooksIssuePerformedViaGithubAppEvent.Reminder,
                "repository" => WebhooksIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhooksIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhooksIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhooksIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhooksIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhooksIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhooksIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhooksIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhooksIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhooksIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}