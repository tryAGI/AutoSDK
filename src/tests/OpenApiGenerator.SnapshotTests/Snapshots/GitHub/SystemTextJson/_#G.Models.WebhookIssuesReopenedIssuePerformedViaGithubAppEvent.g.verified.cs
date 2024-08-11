//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowRun,
                "pull_request_review_thread" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                "reminder" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Reminder,
                _ => null,
            };
        }
    }
}