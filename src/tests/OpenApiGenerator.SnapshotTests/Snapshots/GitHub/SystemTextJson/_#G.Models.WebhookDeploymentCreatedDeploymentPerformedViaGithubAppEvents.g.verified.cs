//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents
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
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        MergeQueueEntry,
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Create => "create",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Delete => "delete",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Fork => "fork",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Issues => "issues",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Label => "label",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Member => "member",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Membership => "membership",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Organization => "organization",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Project => "project",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Public => "public",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Push => "push",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Release => "release",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Repository => "repository",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Star => "star",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Status => "status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Team => "team",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Watch => "watch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.WorkflowJob => "workflow_job",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.MergeGroup => "merge_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Create,
                "delete" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Label,
                "member" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Member,
                "membership" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Project,
                "project_card" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Release,
                "repository" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Star,
                "status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Status,
                "team" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Team,
                "team_add" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.WorkflowRun,
                "workflow_job" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.WorkflowJob,
                "pull_request_review_thread" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.PullRequestReviewThread,
                "merge_queue_entry" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.MergeQueueEntry,
                "secret_scanning_alert_location" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.SecretScanningAlertLocation,
                "merge_group" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvents.MergeGroup,
                _ => null,
            };
        }
    }
}