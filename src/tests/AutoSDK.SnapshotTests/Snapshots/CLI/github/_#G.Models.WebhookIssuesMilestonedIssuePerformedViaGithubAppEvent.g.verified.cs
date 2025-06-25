//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhookIssuesMilestonedIssuePerformedViaGithubAppEvent.Reminder,
                _ => null,
            };
        }
    }
}