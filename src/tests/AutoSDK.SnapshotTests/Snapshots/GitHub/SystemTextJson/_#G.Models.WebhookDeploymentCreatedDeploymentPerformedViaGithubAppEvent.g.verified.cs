//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Create => "create",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Delete => "delete",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Fork => "fork",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Issues => "issues",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Label => "label",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Member => "member",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Membership => "membership",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Organization => "organization",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Project => "project",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Public => "public",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Push => "push",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Release => "release",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Repository => "repository",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Star => "star",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Status => "status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Team => "team",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Watch => "watch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob => "workflow_job",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup => "merge_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Create,
                "delete" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Label,
                "member" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Member,
                "membership" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Project,
                "project_card" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Release,
                "repository" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Star,
                "status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Status,
                "team" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Team,
                "team_add" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun,
                "workflow_job" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob,
                "pull_request_review_thread" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread,
                "merge_queue_entry" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry,
                "secret_scanning_alert_location" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation,
                "merge_group" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup,
                _ => null,
            };
        }
    }
}