//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent
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
    public static class WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}