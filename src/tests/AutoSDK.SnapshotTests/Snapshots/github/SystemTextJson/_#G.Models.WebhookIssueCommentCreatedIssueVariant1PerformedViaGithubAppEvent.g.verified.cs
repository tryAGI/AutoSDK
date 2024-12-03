//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent
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
        PullRequestReviewThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.Reminder,
                "pull_request_review_thread" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}