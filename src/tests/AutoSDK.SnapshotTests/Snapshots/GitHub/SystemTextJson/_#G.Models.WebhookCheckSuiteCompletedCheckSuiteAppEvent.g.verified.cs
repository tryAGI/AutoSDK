//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppEvent
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppEvent value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.CheckRun => "check_run",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.CheckSuite => "check_suite",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.CommitComment => "commit_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ContentReference => "content_reference",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Create => "create",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Delete => "delete",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Deployment => "deployment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentReview => "deployment_review",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeployKey => "deploy_key",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Discussion => "discussion",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Fork => "fork",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Gollum => "gollum",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Issues => "issues",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.IssueComment => "issue_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Label => "label",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Member => "member",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Membership => "membership",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Milestone => "milestone",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Organization => "organization",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.OrgBlock => "org_block",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PageBuild => "page_build",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Project => "project",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectCard => "project_card",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectColumn => "project_column",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Public => "public",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequest => "pull_request",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Push => "push",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.RegistryPackage => "registry_package",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Release => "release",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Repository => "repository",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Star => "star",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Status => "status",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Team => "team",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.TeamAdd => "team_add",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Watch => "watch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowRun => "workflow_run",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeGroup => "merge_group",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowJob => "workflow_job",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectsV2Item => "projects_v2_item",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.BranchProtectionRule,
                "check_run" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.CheckRun,
                "check_suite" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.CommitComment,
                "content_reference" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ContentReference,
                "create" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Create,
                "delete" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Delete,
                "deployment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Deployment,
                "deployment_review" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentStatus,
                "deploy_key" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeployKey,
                "discussion" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Discussion,
                "discussion_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DiscussionComment,
                "fork" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Fork,
                "gollum" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Gollum,
                "issues" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Issues,
                "issue_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.IssueComment,
                "label" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Label,
                "member" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Member,
                "membership" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Membership,
                "milestone" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Milestone,
                "organization" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Organization,
                "org_block" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.OrgBlock,
                "page_build" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PageBuild,
                "project" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Project,
                "project_card" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectCard,
                "project_column" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectColumn,
                "public" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Public,
                "pull_request" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequest,
                "pull_request_review" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewComment,
                "push" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Push,
                "registry_package" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.RegistryPackage,
                "release" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Release,
                "repository" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Repository,
                "repository_dispatch" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlert,
                "star" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Star,
                "status" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Status,
                "team" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Team,
                "team_add" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.TeamAdd,
                "watch" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Watch,
                "workflow_dispatch" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowRun,
                "merge_group" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeGroup,
                "pull_request_review_thread" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewThread,
                "workflow_job" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowJob,
                "merge_queue_entry" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeQueueEntry,
                "security_and_analysis" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecurityAndAnalysis,
                "projects_v2_item" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectsV2Item,
                "secret_scanning_alert_location" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlertLocation,
                _ => null,
            };
        }
    }
}