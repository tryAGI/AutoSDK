//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2PerformedViaGithubAppEvent
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssue2PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhooksIssue2PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhooksIssue2PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhooksIssue2PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhooksIssue2PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhooksIssue2PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhooksIssue2PerformedViaGithubAppEvent.Create => "create",
                WebhooksIssue2PerformedViaGithubAppEvent.Delete => "delete",
                WebhooksIssue2PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhooksIssue2PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhooksIssue2PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhooksIssue2PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhooksIssue2PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhooksIssue2PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhooksIssue2PerformedViaGithubAppEvent.Fork => "fork",
                WebhooksIssue2PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhooksIssue2PerformedViaGithubAppEvent.Issues => "issues",
                WebhooksIssue2PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhooksIssue2PerformedViaGithubAppEvent.Label => "label",
                WebhooksIssue2PerformedViaGithubAppEvent.Member => "member",
                WebhooksIssue2PerformedViaGithubAppEvent.Membership => "membership",
                WebhooksIssue2PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhooksIssue2PerformedViaGithubAppEvent.Organization => "organization",
                WebhooksIssue2PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhooksIssue2PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhooksIssue2PerformedViaGithubAppEvent.Project => "project",
                WebhooksIssue2PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhooksIssue2PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhooksIssue2PerformedViaGithubAppEvent.Public => "public",
                WebhooksIssue2PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhooksIssue2PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhooksIssue2PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhooksIssue2PerformedViaGithubAppEvent.Push => "push",
                WebhooksIssue2PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhooksIssue2PerformedViaGithubAppEvent.Release => "release",
                WebhooksIssue2PerformedViaGithubAppEvent.Repository => "repository",
                WebhooksIssue2PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhooksIssue2PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhooksIssue2PerformedViaGithubAppEvent.Star => "star",
                WebhooksIssue2PerformedViaGithubAppEvent.Status => "status",
                WebhooksIssue2PerformedViaGithubAppEvent.Team => "team",
                WebhooksIssue2PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhooksIssue2PerformedViaGithubAppEvent.Watch => "watch",
                WebhooksIssue2PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhooksIssue2PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhooksIssue2PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhooksIssue2PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhooksIssue2PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhooksIssue2PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhooksIssue2PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhooksIssue2PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhooksIssue2PerformedViaGithubAppEvent.Create,
                "delete" => WebhooksIssue2PerformedViaGithubAppEvent.Delete,
                "deployment" => WebhooksIssue2PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhooksIssue2PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhooksIssue2PerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhooksIssue2PerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhooksIssue2PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhooksIssue2PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhooksIssue2PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhooksIssue2PerformedViaGithubAppEvent.Gollum,
                "issues" => WebhooksIssue2PerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhooksIssue2PerformedViaGithubAppEvent.IssueComment,
                "label" => WebhooksIssue2PerformedViaGithubAppEvent.Label,
                "member" => WebhooksIssue2PerformedViaGithubAppEvent.Member,
                "membership" => WebhooksIssue2PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhooksIssue2PerformedViaGithubAppEvent.Milestone,
                "organization" => WebhooksIssue2PerformedViaGithubAppEvent.Organization,
                "org_block" => WebhooksIssue2PerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhooksIssue2PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhooksIssue2PerformedViaGithubAppEvent.Project,
                "project_card" => WebhooksIssue2PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhooksIssue2PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhooksIssue2PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhooksIssue2PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhooksIssue2PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhooksIssue2PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhooksIssue2PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhooksIssue2PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhooksIssue2PerformedViaGithubAppEvent.Release,
                "repository" => WebhooksIssue2PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhooksIssue2PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhooksIssue2PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhooksIssue2PerformedViaGithubAppEvent.Star,
                "status" => WebhooksIssue2PerformedViaGithubAppEvent.Status,
                "team" => WebhooksIssue2PerformedViaGithubAppEvent.Team,
                "team_add" => WebhooksIssue2PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhooksIssue2PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhooksIssue2PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhooksIssue2PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}