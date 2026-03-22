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
        DeployKey,
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
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        Issues,
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
        MergeGroup,
        /// <summary>
        /// 
        /// </summary>
        MergeQueueEntry,
        /// <summary>
        /// 
        /// </summary>
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
        ProjectsV2Item,
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
        PullRequestReviewThread,
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
        SecretScanningAlertLocation,
        /// <summary>
        /// 
        /// </summary>
        SecurityAndAnalysis,
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
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        WorkflowRun,
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
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeployKey => "deploy_key",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Deployment => "deployment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentReview => "deployment_review",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Discussion => "discussion",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Fork => "fork",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Gollum => "gollum",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.IssueComment => "issue_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Issues => "issues",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Label => "label",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Member => "member",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Membership => "membership",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeGroup => "merge_group",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Milestone => "milestone",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.OrgBlock => "org_block",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Organization => "organization",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PageBuild => "page_build",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Project => "project",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectCard => "project_card",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectColumn => "project_column",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectsV2Item => "projects_v2_item",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Public => "public",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequest => "pull_request",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Push => "push",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.RegistryPackage => "registry_package",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Release => "release",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Repository => "repository",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Star => "star",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Status => "status",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Team => "team",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.TeamAdd => "team_add",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.Watch => "watch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowJob => "workflow_job",
                WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowRun => "workflow_run",
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
                "deploy_key" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeployKey,
                "deployment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Deployment,
                "deployment_review" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DeploymentStatus,
                "discussion" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Discussion,
                "discussion_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.DiscussionComment,
                "fork" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Fork,
                "gollum" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Gollum,
                "issue_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.IssueComment,
                "issues" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Issues,
                "label" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Label,
                "member" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Member,
                "membership" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Membership,
                "merge_group" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeGroup,
                "merge_queue_entry" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.MergeQueueEntry,
                "milestone" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Milestone,
                "org_block" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.OrgBlock,
                "organization" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Organization,
                "page_build" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PageBuild,
                "project" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Project,
                "project_card" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectCard,
                "project_column" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectColumn,
                "projects_v2_item" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.ProjectsV2Item,
                "public" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Public,
                "pull_request" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequest,
                "pull_request_review" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.PullRequestReviewThread,
                "push" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Push,
                "registry_package" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.RegistryPackage,
                "release" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Release,
                "repository" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Repository,
                "repository_dispatch" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlert,
                "secret_scanning_alert_location" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecretScanningAlertLocation,
                "security_and_analysis" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.SecurityAndAnalysis,
                "star" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Star,
                "status" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Status,
                "team" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Team,
                "team_add" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.TeamAdd,
                "watch" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.Watch,
                "workflow_dispatch" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowDispatch,
                "workflow_job" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowJob,
                "workflow_run" => WebhookCheckSuiteCompletedCheckSuiteAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}