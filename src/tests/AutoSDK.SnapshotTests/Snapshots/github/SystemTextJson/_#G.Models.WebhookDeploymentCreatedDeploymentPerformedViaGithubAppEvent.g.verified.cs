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
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Fork => "fork",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Issues => "issues",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Label => "label",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Member => "member",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Membership => "membership",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup => "merge_group",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Organization => "organization",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Project => "project",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Public => "public",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Push => "push",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Release => "release",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Repository => "repository",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Star => "star",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Status => "status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Team => "team",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Watch => "watch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob => "workflow_job",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
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
                "deploy_key" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Issues,
                "label" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Label,
                "member" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Member,
                "membership" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Membership,
                "merge_group" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup,
                "merge_queue_entry" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry,
                "milestone" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Project,
                "project_card" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread,
                "push" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Release,
                "repository" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert,
                "secret_scanning_alert_location" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation,
                "star" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Star,
                "status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Status,
                "team" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Team,
                "team_add" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_job" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob,
                "workflow_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}