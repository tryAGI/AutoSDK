//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppEvent
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppEvent value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CheckRun => "check_run",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CheckSuite => "check_suite",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CommitComment => "commit_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ContentReference => "content_reference",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Create => "create",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Delete => "delete",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Deployment => "deployment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentReview => "deployment_review",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeployKey => "deploy_key",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Discussion => "discussion",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Fork => "fork",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Gollum => "gollum",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Issues => "issues",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.IssueComment => "issue_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Label => "label",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Member => "member",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Membership => "membership",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Milestone => "milestone",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Organization => "organization",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.OrgBlock => "org_block",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PageBuild => "page_build",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Project => "project",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectCard => "project_card",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectColumn => "project_column",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Public => "public",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequest => "pull_request",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Push => "push",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.RegistryPackage => "registry_package",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Release => "release",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Repository => "repository",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Star => "star",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Status => "status",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Team => "team",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.TeamAdd => "team_add",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Watch => "watch",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowRun => "workflow_run",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowJob => "workflow_job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.BranchProtectionRule,
                "check_run" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CheckRun,
                "check_suite" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.CommitComment,
                "content_reference" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ContentReference,
                "create" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Create,
                "delete" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Delete,
                "deployment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Deployment,
                "deployment_review" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentStatus,
                "deploy_key" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeployKey,
                "discussion" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Discussion,
                "discussion_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DiscussionComment,
                "fork" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Fork,
                "gollum" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Gollum,
                "issues" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Issues,
                "issue_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.IssueComment,
                "label" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Label,
                "member" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Member,
                "membership" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Membership,
                "milestone" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Milestone,
                "organization" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Organization,
                "org_block" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.OrgBlock,
                "page_build" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PageBuild,
                "project" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Project,
                "project_card" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectCard,
                "project_column" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectColumn,
                "public" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Public,
                "pull_request" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequest,
                "pull_request_review" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewComment,
                "push" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Push,
                "registry_package" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.RegistryPackage,
                "release" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Release,
                "repository" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Repository,
                "repository_dispatch" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.SecretScanningAlert,
                "star" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Star,
                "status" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Status,
                "team" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Team,
                "team_add" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.TeamAdd,
                "watch" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Watch,
                "workflow_dispatch" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowRun,
                "pull_request_review_thread" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewThread,
                "merge_queue_entry" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.MergeQueueEntry,
                "workflow_job" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowJob,
                _ => null,
            };
        }
    }
}