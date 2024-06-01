//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents
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
        MergeQueueEntry,
        /// <summary>
        /// 
        /// </summary>
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        MergeGroup,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlertLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Create => "create",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Delete => "delete",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Fork => "fork",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Issues => "issues",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Label => "label",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Member => "member",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Membership => "membership",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Organization => "organization",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Project => "project",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Public => "public",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Push => "push",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Release => "release",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Repository => "repository",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Star => "star",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Status => "status",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Team => "team",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Watch => "watch",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.WorkflowJob => "workflow_job",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.MergeGroup => "merge_group",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Create,
                "delete" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Label,
                "member" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Member,
                "membership" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Project,
                "project_card" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Release,
                "repository" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Star,
                "status" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Status,
                "team" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Team,
                "team_add" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.WorkflowRun,
                "pull_request_review_thread" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.PullRequestReviewThread,
                "merge_queue_entry" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.MergeQueueEntry,
                "workflow_job" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.WorkflowJob,
                "merge_group" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.MergeGroup,
                "secret_scanning_alert_location" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvents.SecretScanningAlertLocation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}