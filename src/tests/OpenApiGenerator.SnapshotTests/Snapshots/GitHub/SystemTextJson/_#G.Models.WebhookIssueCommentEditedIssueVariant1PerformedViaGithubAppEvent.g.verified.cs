//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Reminder => "reminder",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.Reminder,
                "pull_request_review_thread" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppEvent.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}