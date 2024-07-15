//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppEvents
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
        MergeGroup,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        MergeQueueEntry,
        /// <summary>
        /// 
        /// </summary>
        SecurityAndAnalysis,
        /// <summary>
        /// 
        /// </summary>
        ProjectsV2Item,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlertLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteCompletedCheckSuiteAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppEvents value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.CheckRun => "check_run",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.CheckSuite => "check_suite",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.CommitComment => "commit_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.ContentReference => "content_reference",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Create => "create",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Delete => "delete",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Deployment => "deployment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.DeploymentReview => "deployment_review",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.DeployKey => "deploy_key",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Discussion => "discussion",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Fork => "fork",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Gollum => "gollum",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Issues => "issues",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.IssueComment => "issue_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Label => "label",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Member => "member",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Membership => "membership",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Milestone => "milestone",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Organization => "organization",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.OrgBlock => "org_block",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.PageBuild => "page_build",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Project => "project",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.ProjectCard => "project_card",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.ProjectColumn => "project_column",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Public => "public",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequest => "pull_request",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Push => "push",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.RegistryPackage => "registry_package",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Release => "release",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Repository => "repository",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Star => "star",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Status => "status",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Team => "team",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.TeamAdd => "team_add",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.Watch => "watch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.WorkflowRun => "workflow_run",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.MergeGroup => "merge_group",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.WorkflowJob => "workflow_job",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.ProjectsV2Item => "projects_v2_item",
                WebhookCheckSuiteCompletedCheckSuiteAppEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.BranchProtectionRule,
                "check_run" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.CheckRun,
                "check_suite" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.CommitComment,
                "content_reference" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.ContentReference,
                "create" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Create,
                "delete" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Delete,
                "deployment" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Deployment,
                "deployment_review" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.DeploymentStatus,
                "deploy_key" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.DeployKey,
                "discussion" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Discussion,
                "discussion_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.DiscussionComment,
                "fork" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Fork,
                "gollum" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Gollum,
                "issues" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Issues,
                "issue_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.IssueComment,
                "label" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Label,
                "member" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Member,
                "membership" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Membership,
                "milestone" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Milestone,
                "organization" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Organization,
                "org_block" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.OrgBlock,
                "page_build" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.PageBuild,
                "project" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Project,
                "project_card" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.ProjectCard,
                "project_column" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.ProjectColumn,
                "public" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Public,
                "pull_request" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequest,
                "pull_request_review" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequestReviewComment,
                "push" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Push,
                "registry_package" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.RegistryPackage,
                "release" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Release,
                "repository" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Repository,
                "repository_dispatch" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.SecretScanningAlert,
                "star" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Star,
                "status" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Status,
                "team" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Team,
                "team_add" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.TeamAdd,
                "watch" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.Watch,
                "workflow_dispatch" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.WorkflowRun,
                "merge_group" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.MergeGroup,
                "pull_request_review_thread" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.PullRequestReviewThread,
                "workflow_job" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.WorkflowJob,
                "merge_queue_entry" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.MergeQueueEntry,
                "security_and_analysis" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.SecurityAndAnalysis,
                "projects_v2_item" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.ProjectsV2Item,
                "secret_scanning_alert_location" => WebhookCheckSuiteCompletedCheckSuiteAppEvents.SecretScanningAlertLocation,
                _ => null,
            };
        }
    }
}