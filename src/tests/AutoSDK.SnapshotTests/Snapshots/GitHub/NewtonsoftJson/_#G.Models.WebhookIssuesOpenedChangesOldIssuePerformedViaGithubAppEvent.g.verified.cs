//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}