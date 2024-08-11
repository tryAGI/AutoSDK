//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}