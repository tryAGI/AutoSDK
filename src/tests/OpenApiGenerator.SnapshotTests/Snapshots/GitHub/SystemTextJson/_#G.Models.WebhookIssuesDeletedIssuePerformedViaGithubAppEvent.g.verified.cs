//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.Reminder,
                _ => null,
            };
        }
    }
}