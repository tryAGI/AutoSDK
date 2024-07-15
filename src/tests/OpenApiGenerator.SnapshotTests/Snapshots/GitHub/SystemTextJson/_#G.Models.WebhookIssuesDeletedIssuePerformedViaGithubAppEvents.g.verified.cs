//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppEvents
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvents.Reminder,
                _ => null,
            };
        }
    }
}