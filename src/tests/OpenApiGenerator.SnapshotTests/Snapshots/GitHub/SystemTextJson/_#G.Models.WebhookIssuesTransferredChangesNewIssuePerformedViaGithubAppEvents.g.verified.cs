//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvents.WorkflowRun,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}