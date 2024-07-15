//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents
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
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Create => "create",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Delete => "delete",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Fork => "fork",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Issues => "issues",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Label => "label",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Member => "member",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Membership => "membership",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Organization => "organization",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Project => "project",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Public => "public",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Push => "push",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Release => "release",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Repository => "repository",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Star => "star",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Status => "status",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Team => "team",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Watch => "watch",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.WorkflowJob => "workflow_job",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.MergeGroup => "merge_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Create,
                "delete" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Label,
                "member" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Member,
                "membership" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Project,
                "project_card" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Release,
                "repository" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Star,
                "status" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Status,
                "team" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Team,
                "team_add" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.WorkflowRun,
                "merge_queue_entry" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.MergeQueueEntry,
                "workflow_job" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.WorkflowJob,
                "pull_request_review_thread" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewThread,
                "secret_scanning_alert_location" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlertLocation,
                "merge_group" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppEvents.MergeGroup,
                _ => null,
            };
        }
    }
}