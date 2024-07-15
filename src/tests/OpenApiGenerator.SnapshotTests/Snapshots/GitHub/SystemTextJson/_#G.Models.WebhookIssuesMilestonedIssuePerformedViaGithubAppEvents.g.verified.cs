//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvents.Reminder,
                _ => null,
            };
        }
    }
}