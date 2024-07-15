//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2PerformedViaGithubAppEvents
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
    public static class WebhooksIssue2PerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhooksIssue2PerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhooksIssue2PerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhooksIssue2PerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhooksIssue2PerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhooksIssue2PerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhooksIssue2PerformedViaGithubAppEvents.Create => "create",
                WebhooksIssue2PerformedViaGithubAppEvents.Delete => "delete",
                WebhooksIssue2PerformedViaGithubAppEvents.Deployment => "deployment",
                WebhooksIssue2PerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhooksIssue2PerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhooksIssue2PerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhooksIssue2PerformedViaGithubAppEvents.Discussion => "discussion",
                WebhooksIssue2PerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhooksIssue2PerformedViaGithubAppEvents.Fork => "fork",
                WebhooksIssue2PerformedViaGithubAppEvents.Gollum => "gollum",
                WebhooksIssue2PerformedViaGithubAppEvents.Issues => "issues",
                WebhooksIssue2PerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhooksIssue2PerformedViaGithubAppEvents.Label => "label",
                WebhooksIssue2PerformedViaGithubAppEvents.Member => "member",
                WebhooksIssue2PerformedViaGithubAppEvents.Membership => "membership",
                WebhooksIssue2PerformedViaGithubAppEvents.Milestone => "milestone",
                WebhooksIssue2PerformedViaGithubAppEvents.Organization => "organization",
                WebhooksIssue2PerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhooksIssue2PerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhooksIssue2PerformedViaGithubAppEvents.Project => "project",
                WebhooksIssue2PerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhooksIssue2PerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhooksIssue2PerformedViaGithubAppEvents.Public => "public",
                WebhooksIssue2PerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhooksIssue2PerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhooksIssue2PerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhooksIssue2PerformedViaGithubAppEvents.Push => "push",
                WebhooksIssue2PerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhooksIssue2PerformedViaGithubAppEvents.Release => "release",
                WebhooksIssue2PerformedViaGithubAppEvents.Repository => "repository",
                WebhooksIssue2PerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhooksIssue2PerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhooksIssue2PerformedViaGithubAppEvents.Star => "star",
                WebhooksIssue2PerformedViaGithubAppEvents.Status => "status",
                WebhooksIssue2PerformedViaGithubAppEvents.Team => "team",
                WebhooksIssue2PerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhooksIssue2PerformedViaGithubAppEvents.Watch => "watch",
                WebhooksIssue2PerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhooksIssue2PerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhooksIssue2PerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhooksIssue2PerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhooksIssue2PerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhooksIssue2PerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhooksIssue2PerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhooksIssue2PerformedViaGithubAppEvents.ContentReference,
                "create" => WebhooksIssue2PerformedViaGithubAppEvents.Create,
                "delete" => WebhooksIssue2PerformedViaGithubAppEvents.Delete,
                "deployment" => WebhooksIssue2PerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhooksIssue2PerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhooksIssue2PerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhooksIssue2PerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhooksIssue2PerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhooksIssue2PerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhooksIssue2PerformedViaGithubAppEvents.Fork,
                "gollum" => WebhooksIssue2PerformedViaGithubAppEvents.Gollum,
                "issues" => WebhooksIssue2PerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhooksIssue2PerformedViaGithubAppEvents.IssueComment,
                "label" => WebhooksIssue2PerformedViaGithubAppEvents.Label,
                "member" => WebhooksIssue2PerformedViaGithubAppEvents.Member,
                "membership" => WebhooksIssue2PerformedViaGithubAppEvents.Membership,
                "milestone" => WebhooksIssue2PerformedViaGithubAppEvents.Milestone,
                "organization" => WebhooksIssue2PerformedViaGithubAppEvents.Organization,
                "org_block" => WebhooksIssue2PerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhooksIssue2PerformedViaGithubAppEvents.PageBuild,
                "project" => WebhooksIssue2PerformedViaGithubAppEvents.Project,
                "project_card" => WebhooksIssue2PerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhooksIssue2PerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhooksIssue2PerformedViaGithubAppEvents.Public,
                "pull_request" => WebhooksIssue2PerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhooksIssue2PerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhooksIssue2PerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhooksIssue2PerformedViaGithubAppEvents.Push,
                "registry_package" => WebhooksIssue2PerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhooksIssue2PerformedViaGithubAppEvents.Release,
                "repository" => WebhooksIssue2PerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhooksIssue2PerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhooksIssue2PerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhooksIssue2PerformedViaGithubAppEvents.Star,
                "status" => WebhooksIssue2PerformedViaGithubAppEvents.Status,
                "team" => WebhooksIssue2PerformedViaGithubAppEvents.Team,
                "team_add" => WebhooksIssue2PerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhooksIssue2PerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhooksIssue2PerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhooksIssue2PerformedViaGithubAppEvents.WorkflowRun,
                _ => null,
            };
        }
    }
}