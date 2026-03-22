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
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeployKey => "deploy_key",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Deployment => "deployment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentReview => "deployment_review",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentStatus => "deployment_status",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Discussion => "discussion",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DiscussionComment => "discussion_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Fork => "fork",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Gollum => "gollum",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.IssueComment => "issue_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Issues => "issues",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Label => "label",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Member => "member",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Membership => "membership",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Milestone => "milestone",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.OrgBlock => "org_block",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Organization => "organization",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PageBuild => "page_build",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Project => "project",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectCard => "project_card",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectColumn => "project_column",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Public => "public",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequest => "pull_request",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReview => "pull_request_review",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewThread => "pull_request_review_thread",
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
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowJob => "workflow_job",
                WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowRun => "workflow_run",
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
                "deploy_key" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeployKey,
                "deployment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Deployment,
                "deployment_review" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentReview,
                "deployment_status" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DeploymentStatus,
                "discussion" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Discussion,
                "discussion_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.DiscussionComment,
                "fork" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Fork,
                "gollum" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Gollum,
                "issue_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.IssueComment,
                "issues" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Issues,
                "label" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Label,
                "member" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Member,
                "membership" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Membership,
                "merge_queue_entry" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.MergeQueueEntry,
                "milestone" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Milestone,
                "org_block" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.OrgBlock,
                "organization" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Organization,
                "page_build" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PageBuild,
                "project" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Project,
                "project_card" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectCard,
                "project_column" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.ProjectColumn,
                "public" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.Public,
                "pull_request" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequest,
                "pull_request_review" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.PullRequestReviewThread,
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
                "workflow_job" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowJob,
                "workflow_run" => WebhookCheckSuiteRerequestedCheckSuiteAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}