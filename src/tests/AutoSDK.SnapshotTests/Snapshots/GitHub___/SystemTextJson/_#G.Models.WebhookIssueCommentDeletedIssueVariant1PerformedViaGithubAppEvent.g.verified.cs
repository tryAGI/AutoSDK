//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}