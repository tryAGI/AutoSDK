//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_protection_rule")]
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_run")]
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_suite")]
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_scanning_alert")]
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_comment")]
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_reference")]
        ContentReference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create")]
        Create,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment")]
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_review")]
        DeploymentReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_status")]
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deploy_key")]
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion")]
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_comment")]
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fork")]
        Fork,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gollum")]
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issues")]
        Issues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_comment")]
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="label")]
        Label,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="membership")]
        Membership,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="milestone")]
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_block")]
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_build")]
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_card")]
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_column")]
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review")]
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_comment")]
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registry_package")]
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="release")]
        Release,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository")]
        Repository,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository_dispatch")]
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert")]
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="star")]
        Star,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team_add")]
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watch")]
        Watch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_dispatch")]
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_run")]
        WorkflowRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_thread")]
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_queue_entry")]
        MergeQueueEntry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_job")]
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_group")]
        MergeGroup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert_location")]
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