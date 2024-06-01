//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppEvents
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
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        Reminder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "pull_request_review_thread" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                "reminder" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvents.Reminder,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}