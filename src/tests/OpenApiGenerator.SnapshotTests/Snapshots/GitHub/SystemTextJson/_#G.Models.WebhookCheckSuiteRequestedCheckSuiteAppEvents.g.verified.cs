//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppEvents
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
        SecretScanningAlertLocation,
        /// <summary>
        /// 
        /// </summary>
        ProjectsV2Item,
        /// <summary>
        /// 
        /// </summary>
        MergeGroup,
        /// <summary>
        /// 
        /// </summary>
        RepositoryImport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRequestedCheckSuiteAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppEvents value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.CheckRun => "check_run",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.CheckSuite => "check_suite",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.CommitComment => "commit_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.ContentReference => "content_reference",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Create => "create",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Delete => "delete",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Deployment => "deployment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.DeploymentReview => "deployment_review",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.DeployKey => "deploy_key",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Discussion => "discussion",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Fork => "fork",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Gollum => "gollum",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Issues => "issues",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.IssueComment => "issue_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Label => "label",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Member => "member",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Membership => "membership",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Milestone => "milestone",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Organization => "organization",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.OrgBlock => "org_block",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.PageBuild => "page_build",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Project => "project",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.ProjectCard => "project_card",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.ProjectColumn => "project_column",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Public => "public",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequest => "pull_request",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Push => "push",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.RegistryPackage => "registry_package",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Release => "release",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Repository => "repository",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Star => "star",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Status => "status",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Team => "team",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.TeamAdd => "team_add",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.Watch => "watch",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.WorkflowRun => "workflow_run",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.WorkflowJob => "workflow_job",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.ProjectsV2Item => "projects_v2_item",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.MergeGroup => "merge_group",
                WebhookCheckSuiteRequestedCheckSuiteAppEvents.RepositoryImport => "repository_import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.BranchProtectionRule,
                "check_run" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.CheckRun,
                "check_suite" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.CommitComment,
                "content_reference" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.ContentReference,
                "create" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Create,
                "delete" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Delete,
                "deployment" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Deployment,
                "deployment_review" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.DeploymentStatus,
                "deploy_key" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.DeployKey,
                "discussion" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Discussion,
                "discussion_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.DiscussionComment,
                "fork" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Fork,
                "gollum" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Gollum,
                "issues" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Issues,
                "issue_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.IssueComment,
                "label" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Label,
                "member" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Member,
                "membership" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Membership,
                "milestone" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Milestone,
                "organization" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Organization,
                "org_block" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.OrgBlock,
                "page_build" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.PageBuild,
                "project" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Project,
                "project_card" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.ProjectCard,
                "project_column" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.ProjectColumn,
                "public" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Public,
                "pull_request" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequest,
                "pull_request_review" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequestReviewComment,
                "push" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Push,
                "registry_package" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.RegistryPackage,
                "release" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Release,
                "repository" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Repository,
                "repository_dispatch" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.SecretScanningAlert,
                "star" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Star,
                "status" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Status,
                "team" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Team,
                "team_add" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.TeamAdd,
                "watch" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.Watch,
                "workflow_dispatch" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.WorkflowRun,
                "pull_request_review_thread" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.PullRequestReviewThread,
                "workflow_job" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.WorkflowJob,
                "merge_queue_entry" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.MergeQueueEntry,
                "security_and_analysis" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.SecurityAndAnalysis,
                "secret_scanning_alert_location" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.SecretScanningAlertLocation,
                "projects_v2_item" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.ProjectsV2Item,
                "merge_group" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.MergeGroup,
                "repository_import" => WebhookCheckSuiteRequestedCheckSuiteAppEvents.RepositoryImport,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}