//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppEvent
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
    public static class WebhookCheckSuiteRequestedCheckSuiteAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppEvent value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.CheckRun => "check_run",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.CheckSuite => "check_suite",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.CommitComment => "commit_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.ContentReference => "content_reference",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Create => "create",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Delete => "delete",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Deployment => "deployment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.DeploymentReview => "deployment_review",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.DeployKey => "deploy_key",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Discussion => "discussion",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Fork => "fork",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Gollum => "gollum",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Issues => "issues",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.IssueComment => "issue_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Label => "label",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Member => "member",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Membership => "membership",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Milestone => "milestone",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Organization => "organization",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.OrgBlock => "org_block",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.PageBuild => "page_build",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Project => "project",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.ProjectCard => "project_card",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.ProjectColumn => "project_column",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Public => "public",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequest => "pull_request",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Push => "push",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.RegistryPackage => "registry_package",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Release => "release",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Repository => "repository",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Star => "star",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Status => "status",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Team => "team",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.TeamAdd => "team_add",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.Watch => "watch",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.WorkflowRun => "workflow_run",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.WorkflowJob => "workflow_job",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.ProjectsV2Item => "projects_v2_item",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.MergeGroup => "merge_group",
                WebhookCheckSuiteRequestedCheckSuiteAppEvent.RepositoryImport => "repository_import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.BranchProtectionRule,
                "check_run" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.CheckRun,
                "check_suite" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.CommitComment,
                "content_reference" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.ContentReference,
                "create" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Create,
                "delete" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Delete,
                "deployment" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Deployment,
                "deployment_review" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.DeploymentStatus,
                "deploy_key" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.DeployKey,
                "discussion" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Discussion,
                "discussion_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.DiscussionComment,
                "fork" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Fork,
                "gollum" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Gollum,
                "issues" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Issues,
                "issue_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.IssueComment,
                "label" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Label,
                "member" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Member,
                "membership" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Membership,
                "milestone" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Milestone,
                "organization" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Organization,
                "org_block" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.OrgBlock,
                "page_build" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.PageBuild,
                "project" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Project,
                "project_card" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.ProjectCard,
                "project_column" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.ProjectColumn,
                "public" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Public,
                "pull_request" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequest,
                "pull_request_review" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequestReviewComment,
                "push" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Push,
                "registry_package" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.RegistryPackage,
                "release" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Release,
                "repository" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Repository,
                "repository_dispatch" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.SecretScanningAlert,
                "star" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Star,
                "status" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Status,
                "team" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Team,
                "team_add" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.TeamAdd,
                "watch" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.Watch,
                "workflow_dispatch" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.WorkflowRun,
                "pull_request_review_thread" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.PullRequestReviewThread,
                "workflow_job" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.WorkflowJob,
                "merge_queue_entry" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.MergeQueueEntry,
                "security_and_analysis" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.SecurityAndAnalysis,
                "secret_scanning_alert_location" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.SecretScanningAlertLocation,
                "projects_v2_item" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.ProjectsV2Item,
                "merge_group" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.MergeGroup,
                "repository_import" => WebhookCheckSuiteRequestedCheckSuiteAppEvent.RepositoryImport,
                _ => null,
            };
        }
    }
}