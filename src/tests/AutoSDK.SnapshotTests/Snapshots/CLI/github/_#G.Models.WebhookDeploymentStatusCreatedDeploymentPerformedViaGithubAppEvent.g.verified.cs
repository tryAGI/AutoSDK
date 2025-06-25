//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent
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
        MergeQueueEntry,
        /// <summary>
        /// 
        /// </summary>
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlertLocation,
        /// <summary>
        /// 
        /// </summary>
        MergeGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Create => "create",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Delete => "delete",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Fork => "fork",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Issues => "issues",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Label => "label",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Member => "member",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Membership => "membership",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Organization => "organization",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Project => "project",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Public => "public",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Push => "push",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Release => "release",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Repository => "repository",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Star => "star",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Status => "status",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Team => "team",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Watch => "watch",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob => "workflow_job",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup => "merge_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Create,
                "delete" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Label,
                "member" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Member,
                "membership" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Project,
                "project_card" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Release,
                "repository" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Star,
                "status" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Status,
                "team" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Team,
                "team_add" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun,
                "merge_queue_entry" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry,
                "workflow_job" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob,
                "pull_request_review_thread" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread,
                "secret_scanning_alert_location" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation,
                "merge_group" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup,
                _ => null,
            };
        }
    }
}