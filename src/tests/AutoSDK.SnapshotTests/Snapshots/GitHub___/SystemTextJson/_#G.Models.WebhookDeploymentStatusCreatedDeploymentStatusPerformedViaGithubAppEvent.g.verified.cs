//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent
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
    public static class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Create => "create",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Delete => "delete",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Fork => "fork",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Issues => "issues",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Label => "label",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Member => "member",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Membership => "membership",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Organization => "organization",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Project => "project",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Public => "public",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Push => "push",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Release => "release",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Repository => "repository",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Star => "star",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Status => "status",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Team => "team",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Watch => "watch",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.WorkflowJob => "workflow_job",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.MergeGroup => "merge_group",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Create,
                "delete" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Label,
                "member" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Member,
                "membership" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Project,
                "project_card" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Release,
                "repository" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Star,
                "status" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Status,
                "team" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Team,
                "team_add" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.WorkflowRun,
                "pull_request_review_thread" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.PullRequestReviewThread,
                "merge_queue_entry" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.MergeQueueEntry,
                "workflow_job" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.WorkflowJob,
                "merge_group" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.MergeGroup,
                "secret_scanning_alert_location" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.SecretScanningAlertLocation,
                _ => null,
            };
        }
    }
}