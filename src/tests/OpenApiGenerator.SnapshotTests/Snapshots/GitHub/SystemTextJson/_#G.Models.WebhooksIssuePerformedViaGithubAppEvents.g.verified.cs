//HintName: G.Models.WebhooksIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssuePerformedViaGithubAppEvents
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
    public static class WebhooksIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhooksIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhooksIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhooksIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhooksIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhooksIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhooksIssuePerformedViaGithubAppEvents.Create => "create",
                WebhooksIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhooksIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhooksIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhooksIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhooksIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhooksIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhooksIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhooksIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhooksIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhooksIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhooksIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhooksIssuePerformedViaGithubAppEvents.Label => "label",
                WebhooksIssuePerformedViaGithubAppEvents.Member => "member",
                WebhooksIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhooksIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhooksIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhooksIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhooksIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhooksIssuePerformedViaGithubAppEvents.Project => "project",
                WebhooksIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhooksIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhooksIssuePerformedViaGithubAppEvents.Public => "public",
                WebhooksIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhooksIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhooksIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhooksIssuePerformedViaGithubAppEvents.Push => "push",
                WebhooksIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhooksIssuePerformedViaGithubAppEvents.Release => "release",
                WebhooksIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhooksIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhooksIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhooksIssuePerformedViaGithubAppEvents.Star => "star",
                WebhooksIssuePerformedViaGithubAppEvents.Status => "status",
                WebhooksIssuePerformedViaGithubAppEvents.Team => "team",
                WebhooksIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhooksIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhooksIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhooksIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhooksIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                WebhooksIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhooksIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhooksIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhooksIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhooksIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhooksIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhooksIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhooksIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhooksIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhooksIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhooksIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhooksIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhooksIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhooksIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhooksIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhooksIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhooksIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhooksIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhooksIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhooksIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhooksIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhooksIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhooksIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhooksIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhooksIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhooksIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhooksIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhooksIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhooksIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhooksIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhooksIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhooksIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhooksIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhooksIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhooksIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhooksIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhooksIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhooksIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhooksIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhooksIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhooksIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhooksIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhooksIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhooksIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhooksIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhooksIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhooksIssuePerformedViaGithubAppEvents.Reminder,
                "pull_request_review_thread" => WebhooksIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}