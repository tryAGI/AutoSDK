//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppEvents
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppEvents value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CheckRun => "check_run",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CheckSuite => "check_suite",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CommitComment => "commit_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.ContentReference => "content_reference",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Create => "create",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Delete => "delete",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Deployment => "deployment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DeploymentReview => "deployment_review",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DeployKey => "deploy_key",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Discussion => "discussion",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Fork => "fork",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Gollum => "gollum",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Issues => "issues",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.IssueComment => "issue_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Label => "label",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Member => "member",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Membership => "membership",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Milestone => "milestone",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Organization => "organization",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.OrgBlock => "org_block",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PageBuild => "page_build",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Project => "project",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.ProjectCard => "project_card",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.ProjectColumn => "project_column",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Public => "public",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequest => "pull_request",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Push => "push",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.RegistryPackage => "registry_package",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Release => "release",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Repository => "repository",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Star => "star",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Status => "status",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Team => "team",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.TeamAdd => "team_add",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Watch => "watch",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.WorkflowRun => "workflow_run",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvents.WorkflowJob => "workflow_job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.BranchProtectionRule,
                "check_run" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CheckRun,
                "check_suite" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.CommitComment,
                "content_reference" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.ContentReference,
                "create" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Create,
                "delete" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Delete,
                "deployment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Deployment,
                "deployment_review" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DeploymentStatus,
                "deploy_key" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DeployKey,
                "discussion" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Discussion,
                "discussion_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.DiscussionComment,
                "fork" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Fork,
                "gollum" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Gollum,
                "issues" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Issues,
                "issue_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.IssueComment,
                "label" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Label,
                "member" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Member,
                "membership" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Membership,
                "milestone" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Milestone,
                "organization" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Organization,
                "org_block" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.OrgBlock,
                "page_build" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PageBuild,
                "project" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Project,
                "project_card" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.ProjectCard,
                "project_column" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.ProjectColumn,
                "public" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Public,
                "pull_request" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequest,
                "pull_request_review" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequestReviewComment,
                "push" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Push,
                "registry_package" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.RegistryPackage,
                "release" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Release,
                "repository" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Repository,
                "repository_dispatch" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.SecretScanningAlert,
                "star" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Star,
                "status" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Status,
                "team" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Team,
                "team_add" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.TeamAdd,
                "watch" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.Watch,
                "workflow_dispatch" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.WorkflowRun,
                "pull_request_review_thread" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.PullRequestReviewThread,
                "merge_queue_entry" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.MergeQueueEntry,
                "workflow_job" => WebhookCheckSuiteRerequestedCheckSuiteAppEvents.WorkflowJob,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}