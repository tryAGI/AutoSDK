//HintName: G.Models.WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssueCommentDeletedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppEvents.WorkflowRun,
                _ => null,
            };
        }
    }
}